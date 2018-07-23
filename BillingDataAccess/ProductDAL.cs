using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
    public class ProductDAL : BaseClassDAL
    {
        public ProductDAL(DBHelper _dbHelper)
             : base(_dbHelper)
        { }


        //public DataTable GetAllProduct()
        //{          
        //   string strQuery = "";          
        //    dbHelper.SelectParameterClear();
        //    return dbHelper.GetDataInDataTable(CommandType.Text, strQuery);
        //}

        public DataTable GetAllProduct(int? productId)
        {
            dbHelper.SelectParameter("@ProductID", DbType.Int32, productId);
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Product");
            return dtProductDetails;
        }

        public DataTable GetAllSubCategory(int? ProductSubCategoryID,int ? ProductCategoryID)
        {
           
            dbHelper.SelectParameter("@ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);
            dbHelper.SelectParameter("@ProductCategoryID", DbType.Int32, ProductCategoryID);
            DataTable dtSubCategoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_ProductSubCategory");
            return dtSubCategoryDetails;
        }

        public DataTable GetAllSize(int? sizeId)
        {
            dbHelper.SelectParameter("@SizeID", DbType.Int32, sizeId);
            DataTable dtSizeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Size");
            return dtSizeDetails;
        }
        public DataTable GetAllUnit(int? unitId)
        {
            dbHelper.SelectParameter("@UnitID", DbType.Int32, unitId);
            DataTable dtSizeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Unit");
            return dtSizeDetails;
        }

        public DataTable GetAllTax(int? taxID)
        {
            dbHelper.SelectParameter("@TaxID", DbType.Int32, taxID);
            DataTable dtSizeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Tax");
            return dtSizeDetails;
        }

        //public DataTable GetAllProduct()
        //{
        //    //dbHelper.InsertUpdateDeleteParameter("@ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);            
        //    DataTable dtProductSubCategoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "Select_Product");
        //    return dtProductSubCategoryDetails;
        //}

        public bool ProductSave(int ProductID, int ProductCategoryID, int  ProductSubCategoryID, string ProductName, string ProductDescription, string Make, string Unit, int TaxID,
            int SizeID, decimal RatePerUnit, string Discount, string Remark, DateTime UpdatedOn, Int32 CreatedBy, Int32 UpdatedBy,int unitId)
        {
            dbHelper.InsertUpdateDeleteParameter("@ProductID", DbType.Int32, ProductID);
            dbHelper.InsertUpdateDeleteParameter("@ProductCategoryID", DbType.Int32, ProductCategoryID);
            if(ProductSubCategoryID>0)
            dbHelper.InsertUpdateDeleteParameter("@ProductSubCategoryID", DbType.Int32, ProductSubCategoryID);
            else
                dbHelper.InsertUpdateDeleteParameter("@ProductSubCategoryID", DbType.Int32, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@ProductName", DbType.String, ProductName);
            dbHelper.InsertUpdateDeleteParameter("@ProductDescription", DbType.String, ProductDescription);
            dbHelper.InsertUpdateDeleteParameter("@Make", DbType.String, Make);
            dbHelper.InsertUpdateDeleteParameter("@Unit", DbType.String, Unit);
            dbHelper.InsertUpdateDeleteParameter("@TaxID", DbType.Int32, TaxID);
            dbHelper.InsertUpdateDeleteParameter("@SizeID", DbType.Int32, SizeID);
            dbHelper.InsertUpdateDeleteParameter("@RatePerUnit", DbType.Decimal, RatePerUnit);
            dbHelper.InsertUpdateDeleteParameter("@Discount", DbType.String, Discount);
            dbHelper.InsertUpdateDeleteParameter("@Remark", DbType.String, Remark);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@UnitID", DbType.Int32, unitId);
            
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "InsertUpdate_Product");

            return true;
        }

        public bool ProductDelete(string modifiedBy, string leaveCode)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@MODIFIED_BY", DbType.String, modifiedBy);
            dbHelper.InsertUpdateDeleteParameter("@LEAVE_CODE", DbType.String, leaveCode);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spName");

            return true;
        }

        public bool ProductDelete(int ProductID, DateTime UpdatedOn, int UpdatedBy)
        {
            string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@ProductID", DbType.Int32, ProductID);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Product", "@Check", out outvalue);
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

            string strNotUpdatedAgencies = (string)dbHelper.GetScalarValue(CommandType.StoredProcedure, "spName");
            return strNotUpdatedAgencies;
        }
    }
}
