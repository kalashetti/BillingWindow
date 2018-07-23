using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
   public class ProductCategoryDAL : BaseClassDAL
    {
       public ProductCategoryDAL(DBHelper _dbHelper)
            : base(_dbHelper)
        { }


        //public DataTable GetAllProductCategory()
        //{
        //    string strQuery = "SELECT [ProductCategoryID] ,[CategoryName],[Description] FROM [Billing].[dbo].[tblProductCategory] WHERE IsActive = 1";
        //    dbHelper.SelectParameterClear();
        //    return dbHelper.GetDataInDataTable(CommandType.Text, strQuery);
        //}
         

       public DataTable GetAllProductCategory()
       {          
           dbHelper.SelectParameterClear();           //dbHelper.SelectParameter("ProductCategoryID", DbType.Int32, ProductCategoryID);           
           DataTable dtProductCategoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_ProductCategory");
           return dtProductCategoryDetails;
       }


       public bool ProductCategorySave(int ProductCategoryID, string Name, string Description,DateTime UpdatedOn, string CreatedBy, string UpdatedBy, int HSN_SAC)
       {
           
           dbHelper.InsertUpdateDeleteParameterClear();
           dbHelper.InsertUpdateDeleteParameter("@ProductCategoryID", DbType.Int32, ProductCategoryID);
           dbHelper.InsertUpdateDeleteParameter("@CategoryName", DbType.String, Name);
           dbHelper.InsertUpdateDeleteParameter("@Description", DbType.String, Description);
           dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
           dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, DBNull.Value);
           dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);
            if(HSN_SAC>0)
           dbHelper.InsertUpdateDeleteParameter("@HSN_SAC", DbType.Int32, HSN_SAC);
            else
            dbHelper.InsertUpdateDeleteParameter("@HSN_SAC", DbType.Int32, DBNull.Value);

            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "InsertUpdate_ProductCategory");

           return true;
       }

       public bool ProductCategoryDelete(int ProductCategoryID, DateTime UpdatedOn, int UpdatedBy)
        {
            string outvalue="0"; 
           dbHelper.InsertUpdateDeleteParameterClear();

           dbHelper.InsertUpdateDeleteParameter("@ProductCategoryID", DbType.Int32, ProductCategoryID);
           dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
           dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);           
           dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);            
           dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_ProductCategory", "@Check",out outvalue);
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

     
    }
}
