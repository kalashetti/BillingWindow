using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
   public class ProductSubCategoryDAL : BaseClassDAL
    {
       public ProductSubCategoryDAL(DBHelper _dbHelper)
            : base(_dbHelper)
        { }


        public DataTable GetAllProductSubCategory()
        {
            string strQuery = "SELECT SubCat.[ProductSubCategoryID],SubCat.[ProductCategoryID],SubCat.[SubCategoryName],SubCat.[Description], Cat.[CategoryName] "+
                               "FROM [dbo].[tblProductSubCategory] AS SubCat "+
                                "INNER JOIN [dbo].[tblProductCategory] AS Cat " +
                                "ON SubCat.[ProductCategoryID]= Cat.[ProductCategoryID] " +
                                "WHERE SubCat.IsActive = 1";          
           dbHelper.SelectParameterClear();
           return dbHelper.GetDataInDataTable(CommandType.Text, strQuery);
       }


    public DataSet GetAllProductSubCategory(int ProductSubCategoryID, string CategoryName,  string Description)
       {          
           dbHelper.SelectParameterClear();
           dbHelper.SelectParameter("ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);
           dbHelper.SelectParameter("CategoryName", DbType.String, CategoryName);
           dbHelper.SelectParameter("Description", DbType.String, Description);
           DataSet dtProductSubCategoryDetails = dbHelper.GetDataInDataSet(CommandType.StoredProcedure, "GetAll_ProductSubCategory");
           return dtProductSubCategoryDetails;
       }

    public DataTable GetAllProductSubCategoryWithCategory()
    {
            //dbHelper.InsertUpdateDeleteParameter("@ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);            
            DataTable dtProductSubCategoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_ProductSubCategoryWithProductCategory");
            return dtProductSubCategoryDetails;
    }



    public bool ProductSubCategorySave(int ProductSubCategoryID,int ProductCategoryID,string SubCategoryName, string Description, DateTime UpdatedOn, int CreatedBy, int UpdatedBy)
       {
           dbHelper.InsertUpdateDeleteParameter("@ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);
           dbHelper.InsertUpdateDeleteParameter("@ProductCategoryID", DbType.Int32, ProductCategoryID);
           dbHelper.InsertUpdateDeleteParameter("@SubCategoryName", DbType.String, SubCategoryName);           
           dbHelper.InsertUpdateDeleteParameter("@Description", DbType.String, Description);
           dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
           dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, DBNull.Value);
           dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);           
           dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "InsertUpdate_ProductSubCategory");

           return true;
       }

       public bool ProductSubCategoryDelete(string modifiedBy, string leaveCode)
       {
           dbHelper.InsertUpdateDeleteParameterClear();
           dbHelper.InsertUpdateDeleteParameter("@MODIFIED_BY", DbType.String, modifiedBy);
           dbHelper.InsertUpdateDeleteParameter("@LEAVE_CODE", DbType.String, leaveCode);
           dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spName");

           return true;
       }

        public bool ProductSubCategoryDelete(int ProductSubCategoryID, DateTime UpdatedOn, int UpdatedBy)
        {
            string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();

            dbHelper.InsertUpdateDeleteParameter("@ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_ProductSubCategory", "@Check", out outvalue);
            if (!string.IsNullOrEmpty(outvalue))
            {
                if (outvalue == "1")
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        /// <summary>
        /// return scalre value from inline 
        /// </summary>
        /// <param name="dtStartDate"></param>
        /// <param name="dtEndDate"></param>
        /// <param name="tsProfileCode"></param>
        /// <param name="phProfileCode"></param>
        /// <returns></returns>
        public int getWorkingDaysinWeek(DateTime dtStartDate, DateTime dtEndDate, string tsProfileCode, string phProfileCode)
       {
           tsProfileCode = tsProfileCode.Replace("'", "''");
           phProfileCode = phProfileCode.Replace("'", "''");

           string strSQL = string.Format("select [SYSADM].[fn_GetWorkingDayCount]('{0}', '{1}', N'{2}', N'{3}') ",
               dtStartDate.ToString("yyyy/MM/dd"), dtEndDate.ToString("yyyy/MM/dd"), tsProfileCode, phProfileCode);

           return Convert.ToInt32(dbHelper.GetScalarValue(CommandType.Text, strSQL));
       }
       /// <summary>
       /// return scalre value from sp 
       /// </summary>
       /// <param name="xmlAgencyDets"></param>
       /// <param name="userId"></param>
       /// <returns></returns>
       public string TESetupUpdate(string xmlAgencyDets, string userId)
       {
           dbHelper.SelectParameterClear();
           dbHelper.SelectParameter("@xmlAgencyDets", DbType.String, xmlAgencyDets);
           dbHelper.SelectParameter("@ModifiedBy", DbType.String, userId);

           string strNotUpdatedAgencies = (string)dbHelper.GetScalarValue(CommandType.StoredProcedure,"spName");
           return strNotUpdatedAgencies;
       }
    }
}
