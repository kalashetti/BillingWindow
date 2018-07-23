using System;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Web;

namespace AC.Billing.DataAccess
{
    public class DBHelper
    {

        private string connectionString, providerName, configConnectionStringName;
        private int sqlCommandTimeout = 0;
        private static string readOnlyErrorMsg = string.Empty;

        DbProviderFactory dbFactory;
        DbConnection dbConn;
        DbParameterCollection dbSelectParameter;
        DbParameterCollection dbInsertUpdateDeleteParameter;
        DbTransaction dbTransaction;

        public DBHelper()
        {


            configConnectionStringName = ConfigurationManager.AppSettings["configConnectionStringName"];
            sqlCommandTimeout = int.Parse(ConfigurationManager.AppSettings["sqlCommandTimeout"]);
            connectionString = ConfigurationManager.ConnectionStrings[configConnectionStringName].ConnectionString;
            providerName = ConfigurationManager.ConnectionStrings[configConnectionStringName].ProviderName;
            dbFactory = DbProviderFactories.GetFactory(providerName);
            dbConn = CreateConnection();
            dbSelectParameter = getParameterCollection();
            dbInsertUpdateDeleteParameter = getParameterCollection();
            dbTransaction = null;


        }

        ~DBHelper()
        {
            dbSelectParameter = null;
            dbInsertUpdateDeleteParameter = null;
        }

        public DbConnection CreateConnection()
        {
            DbConnection connection = dbFactory.CreateConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public DataTable GetDataInDataTable(CommandType commandType, string commandText)
        {
            DbCommand dbCommand = dbFactory.CreateCommand();
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbSelectParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = sbp.Direction;
                dbParam.DbType = sbp.DbType;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }

            DbDataAdapter da = dbFactory.CreateDataAdapter();
            da.SelectCommand = dbCommand;
            da.SelectCommand.CommandTimeout = 0;
            DataTable dt = new DataTable();

            try
            {
                if (dbConn.State == ConnectionState.Closed)
                    dbConn.Open();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                SelectParameterClear();
                dbCommand.Dispose(); da.Dispose(); dt.Dispose();
            }
        }

        public DataSet GetDataInDataSet(CommandType commandType, string commandText)
        {
            DbCommand dbCommand = dbFactory.CreateCommand();
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbSelectParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = sbp.Direction;
                dbParam.DbType = sbp.DbType;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }

            DbDataAdapter da = dbFactory.CreateDataAdapter();
            da.SelectCommand = dbCommand;
            da.SelectCommand.CommandTimeout = 0;
            DataSet ds = new DataSet();

            try
            {
                if (dbConn.State == ConnectionState.Closed)
                    dbConn.Open();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                SelectParameterClear();
                dbCommand.Dispose(); da.Dispose(); ds.Dispose();
            }
        }

        /// <summary>
        /// Selects the query.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandText">The command text.</param>
        /// <param name="parameterValue">The parameter value.</param>
        /// <returns></returns>
        public DataTable GetDataInDataTable(CommandType commandType, string commandText, out int parameterValue)
        {
            DbCommand dbCommand = dbFactory.CreateCommand();
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbSelectParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = sbp.Direction;
                dbParam.DbType = sbp.DbType;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }

            DbDataAdapter da = dbFactory.CreateDataAdapter();
            da.SelectCommand = dbCommand;
            da.SelectCommand.CommandTimeout = 0;

            DataTable dt = new DataTable();

            try
            {
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }

                da.Fill(dt);

                parameterValue = Convert.ToInt32(dbCommand.Parameters["@TotalRecords"].Value);
                return dt;
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                SelectParameterClear();
                dbCommand.Dispose(); da.Dispose(); dt.Dispose();
            }
        }


        /// <summary>
        /// Gets the single value query.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        public object GetScalarValue(CommandType commandType, string commandText)
        {
            DbCommand dbCommand = dbFactory.CreateCommand();

            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            dbCommand.CommandTimeout = 0;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbSelectParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = ParameterDirection.Input;
                dbParam.DbType = sbp.DbType;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }
            try
            {
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                return dbCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                SelectParameterClear();
                dbCommand.Dispose();
            }
        }

        /// <summary>
        /// Adds Parameter to SelectParameter collection.
        /// </summary>
        /// <param name="parameterName">Name of the parameter</param>
        /// <param name="dbType">Type of parameter</param>
        /// <param name="value">Value to be passed</param>
        public void SelectParameter(string parameterName, DbType dbType, object value)
        {
            DbParameter sbp = dbFactory.CreateParameter();
            sbp.ParameterName = parameterName;
            sbp.DbType = dbType;
            sbp.Value = value;
            dbSelectParameter.Add(sbp);
        }

        public void SelectParameter(string parameterName, DbType dbType, object value, bool isOutputParmeter)
        {
            DbParameter sbp = dbFactory.CreateParameter();
            sbp.ParameterName = parameterName;
            if (isOutputParmeter)
                sbp.Direction = ParameterDirection.Output;
            else
                sbp.Direction = ParameterDirection.Input;
            sbp.DbType = dbType;
            sbp.Value = value;
            dbSelectParameter.Add(sbp);
        }

        public int InsertUpdateDeleteQuery(CommandType commandType, string commandText)
        {
            DbCommand dbCommand = dbFactory.CreateCommand();
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            dbCommand.CommandTimeout = 0;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbInsertUpdateDeleteParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = sbp.Direction;
                dbParam.DbType = sbp.DbType;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }

            try
            {
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                InsertUpdateDeleteParameterClear();
                dbCommand.Dispose();
            }
        }

        public int InsertUpdateDeleteQuery(CommandType commandType, string commandText, out int lastInserted)
        {
            int affectedRecords = 0;

            DbCommand dbCommand = dbFactory.CreateCommand();
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            dbCommand.CommandTimeout = 0;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbInsertUpdateDeleteParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = sbp.Direction;
                dbParam.DbType = sbp.DbType;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }

            try
            {
                if (dbConn.State == ConnectionState.Closed)
                    dbConn.Open();

                affectedRecords = dbCommand.ExecuteNonQuery();
                lastInserted = Convert.ToInt32(dbCommand.Parameters["@LastInserted"].Value);
                return affectedRecords;
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                InsertUpdateDeleteParameterClear();
                dbCommand.Dispose();
            }
        }

        public int InsertUpdateDeleteQuery(CommandType commandType, string commandText, string outputParam, out string outputParamValue)
        {
            int affectedRecords = 0;

            DbCommand dbCommand = dbFactory.CreateCommand();
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = commandText;
            dbCommand.Connection = dbConn;
            dbCommand.CommandTimeout = 0;
            if (dbTransaction != null) dbCommand.Transaction = dbTransaction;

            DbParameter dbParam;
            foreach (DbParameter sbp in dbInsertUpdateDeleteParameter)
            {
                dbParam = dbFactory.CreateParameter();
                dbParam.ParameterName = sbp.ParameterName;
                dbParam.Direction = sbp.Direction;
                dbParam.DbType = sbp.DbType;
                if (sbp.Direction == ParameterDirection.Output) dbParam.Size = 100000;
                dbParam.Value = sbp.Value;

                dbCommand.Parameters.Add(dbParam);
            }

            try
            {
                if (dbConn.State == ConnectionState.Closed)
                    dbConn.Open();

                affectedRecords = dbCommand.ExecuteNonQuery();
                outputParamValue = dbCommand.Parameters[outputParam].Value.ToString();

                return affectedRecords;
            }
            catch (Exception ex)
            {
                if (readOnlyErrorMsg != string.Empty && ex.Message.Contains(readOnlyErrorMsg))
                    throw new Exception(readOnlyErrorMsg);
                else
                    throw;
            }
            finally
            {
                if (dbTransaction == null && dbConn.State != ConnectionState.Closed) { dbConn.Close(); }
                InsertUpdateDeleteParameterClear();
                dbCommand.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        /// <param name="value"></param>
        public void InsertUpdateDeleteParameter(string parameterName, DbType dbType, object value)
        {
            DbParameter sbp = dbFactory.CreateParameter();
            sbp.ParameterName = parameterName;
            sbp.DbType = dbType;
            sbp.Value = value;
            dbInsertUpdateDeleteParameter.Add(sbp);

        }

        /// <summary>
        /// Inserts the update delete parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="dbType">Type of the db.</param>
        /// <param name="value">The value.</param>
        /// <param name="outputParameter">if set to <c>true</c> [output parameter].</param>
        public void InsertUpdateDeleteParameter(string parameterName, DbType dbType, object value, bool outputParameter)
        {
            DbParameter sbp = dbFactory.CreateParameter();
            sbp.ParameterName = parameterName;
            sbp.DbType = dbType;
            if (outputParameter)
                sbp.Direction = ParameterDirection.Output;
            else
                sbp.Direction = ParameterDirection.Input;

            sbp.Value = value;
            dbInsertUpdateDeleteParameter.Add(sbp);
        }

        /// <summary>
        /// Gets the entity details.
        /// </summary>
        /// <param name="selectFields">The select fields.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="whereClause">The where clause.</param>
        /// <param name="orderBy">The order by.</param>
        /// <returns></returns>
        public DataTable GetEntityDetails(string selectFields, string tableName, string whereClause, string orderBy)
        {
            string strQuery = string.Empty;

            strQuery += "SELECT " + selectFields + " FROM " + tableName + " ";

            if (whereClause != "")
                strQuery += "WHERE " + whereClause + " ";

            if (orderBy != "")
                strQuery += "ORDER BY " + orderBy;

            DataTable dtEntityDetails = GetDataInDataTable(CommandType.Text, strQuery);

            return dtEntityDetails;
        }

        public void SelectParameterClear()
        {
            dbSelectParameter = null;
            dbSelectParameter = getParameterCollection();
        }

        /// <summary>
        /// Clears all the parameter added
        /// </summary>
        public void InsertUpdateDeleteParameterClear()
        {
            dbInsertUpdateDeleteParameter = null;
            dbInsertUpdateDeleteParameter = getParameterCollection();
        }

        public DbParameterCollection getParameterCollection()
        {
            DbParameterCollection paramCollection = null;
            DbCommand cmd = dbFactory.CreateCommand();
            DbParameter prm = (DbParameter)cmd.CreateParameter();
            paramCollection = (DbParameterCollection)cmd.Parameters;

            return paramCollection;
        }

        public string GetDataBaseName()
        {
            return dbConn.Database;
        }

        public string GetProviderName()
        {
            return providerName;
        }

        /// <summary>
        /// Sets a value indicating whether [begin transaction].
        /// </summary>
        /// <value><c>true</c> if [begin transaction]; otherwise, <c>false</c>.</value>
        public void BeginTransaction()
        {
            if (dbConn.State == ConnectionState.Closed) dbConn.Open();
            dbTransaction = dbConn.BeginTransaction();
        }

        /// <summary>
        /// Sets a value indicating whether [commit transaction].
        /// </summary>
        /// <value><c>true</c> if [commit transaction]; otherwise, <c>false</c>.</value>
        public void CommitTransaction()
        {
            if (dbConn.State != ConnectionState.Closed)
            {
                dbTransaction.Commit();
                dbConn.Close();
                dbTransaction = null;
            }
        }

        /// <summary>
        /// Sets a value indicating whether [rollback transaction].
        /// </summary>
        /// <value><c>true</c> if [rollback transaction]; otherwise, <c>false</c>.</value>
        public void RollbackTransaction()
        {
            if (dbConn.State != ConnectionState.Closed)
            {
                dbTransaction.Rollback();
                dbConn.Close();
                dbTransaction = null;
            }
        }
    }
}
