using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AC.Billing.DataAccess
{
    public class InventoryDAL : BaseClassDAL
    {
        public InventoryDAL(DBHelper _dbHelper) 
            : base(_dbHelper)
        {}
        public DataTable GetMax_Inventory()
        {
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetMax_Inventory");
            return dtProductDetails;
        }
        public bool DeleteInventory(int inventoryID, int modifiedBy)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@InventoryID", DbType.Int32, inventoryID);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, modifiedBy);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Inventory");

            return true;
        }
        public DataTable GetInventoryReport(DateTime fromdate, DateTime todate)
        {

            dbHelper.SelectParameter("@FromDate", DbType.DateTime, fromdate);
            dbHelper.SelectParameter("@Todate", DbType.DateTime, todate);
            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "sp_GetMonthlyInventoryReprot");
            return dtInvoiceDetails;
        }
        public DataTable GetAllPaymentMode()
        {
            DataTable dtPaymentModeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_PaymentMode");
            return dtPaymentModeDetails;
        }
        public DataTable GetProduct()
        {
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "Get_Product");
            return dtProductDetails;
        }
        
        public DataTable GetAllInventory(int InventoryID)
        {
            
            dbHelper.SelectParameterClear();
            if (InventoryID > 0)
                dbHelper.SelectParameter("@InventoryID", DbType.Int32, InventoryID);
            else
                dbHelper.SelectParameter("@InventoryID", DbType.Int32, DBNull.Value);
            DataTable dtInventoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Inventory");
            return dtInventoryDetails;
        }

        public DataTable GetAllInventoryItem(int InventoryID, int InventoryItemID)
        {

            dbHelper.SelectParameterClear();
            if (InventoryID > 0)
                dbHelper.SelectParameter("@InventoryID", DbType.Int32, InventoryID);
            else
                dbHelper.SelectParameter("@InventoryID", DbType.Int32, DBNull.Value);

            if (InventoryItemID > 0)
                dbHelper.SelectParameter("@InventoryItemID", DbType.Int32, InventoryID);
            else
                dbHelper.SelectParameter("@InventoryItemID  ", DbType.Int32, DBNull.Value);

            DataTable dtInventoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_InventoryItem");
            return dtInventoryDetails;
        }

        public DataTable GetAllInventoryItemReport(int InventoryID, int InventoryItemID)
        {

            dbHelper.SelectParameterClear();
            if (InventoryID > 0)
                dbHelper.SelectParameter("@InventoryID", DbType.Int32, InventoryID);
            else
                dbHelper.SelectParameter("@InventoryID", DbType.Int32, DBNull.Value);

            if (InventoryItemID > 0)
                dbHelper.SelectParameter("@InventoryItemID", DbType.Int32, InventoryID);
            else
                dbHelper.SelectParameter("@InventoryItemID  ", DbType.Int32, DBNull.Value);

            DataTable dtInventoryDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_InventoryItem_Report");
            return dtInventoryDetails;
        }


        public bool InventorySave(int InventoryID, string InventoryXML, string InventoryItemXML, int CreatedBy)
        {
            dbHelper.InsertUpdateDeleteParameter("@InventoryID", DbType.Int32, InventoryID);
            dbHelper.InsertUpdateDeleteParameter("@InventoryXML", DbType.Xml, InventoryXML);
            dbHelper.InsertUpdateDeleteParameter("@InventoryItemXML", DbType.Xml, InventoryItemXML);
            dbHelper.InsertUpdateDeleteParameter("@modifiedBy", DbType.Int32, CreatedBy);   
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spInventory_InventoryEntrySave");    
            return true;
        }

        public bool InvoiceDelete(string modifiedBy, string leaveCode)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@MODIFIED_BY", DbType.String, modifiedBy);
            dbHelper.InsertUpdateDeleteParameter("@LEAVE_CODE", DbType.String, leaveCode);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spName");

            return true;
        }

        public bool InvoiceDelete(int InvoiceID, DateTime UpdatedOn, int UpdatedBy)
        {
            string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@ProductID", DbType.Int32, InvoiceID);
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
        /// 
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
        /// 
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

