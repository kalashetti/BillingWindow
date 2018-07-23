using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AC.Billing.DataAccess
{
    public class DeliveryNoteDAL : BaseClassDAL
    {
        public DeliveryNoteDAL(DBHelper _dbHelper) 
            : base(_dbHelper)
        {}

        public bool DeleteDeliveryNote(int deliveryNoteID, int modifiedBy)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@DeliveryNoteID", DbType.Int32, deliveryNoteID);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, modifiedBy);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_DeliveryNote");

            return true;
        }
        public DataTable GetDeliveryNoteReport(DateTime fromdate, DateTime todate)
        {

            dbHelper.SelectParameter("@FromDate", DbType.DateTime, fromdate);
            dbHelper.SelectParameter("@Todate", DbType.DateTime, todate);
            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "sp_GetMonthlytblDeliveryNoteReport");
            return dtInvoiceDetails;
        }
        public DataTable GetAllDeliveryMode()
        {
            DataTable dtDeliveryModeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_DeliveryMode");
            return dtDeliveryModeDetails;
        }

        public DataTable GetProduct()
        {
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "Get_Product");
            return dtProductDetails;
        }

        public DataTable GetAllDeliveryNote(int DeliveryNoteID)
        {
            
            dbHelper.SelectParameterClear();
            if (DeliveryNoteID > 0)
                dbHelper.SelectParameter("@DeliveryNoteID", DbType.Int32, DeliveryNoteID);
            else
                dbHelper.SelectParameter("@DeliveryNoteID", DbType.Int32, DBNull.Value);
            DataTable dtDeliveryNoteDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_DeliveryNote");
            return dtDeliveryNoteDetails;
        }

        public DataTable GetAllInvoice()
        {
            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Invoice");
            return dtInvoiceDetails;
        }

        public DataTable GetAllDeliveryNoteItem(int DeliveryNoteID, int DeliveryNoteItemID)
        {

            dbHelper.SelectParameterClear();
            if (DeliveryNoteID > 0)
                dbHelper.SelectParameter("@DeliveryNoteID", DbType.Int32, DeliveryNoteID);
            else
                dbHelper.SelectParameter("@DeliveryNoteID", DbType.Int32, DBNull.Value);

            if (DeliveryNoteItemID > 0)
                dbHelper.SelectParameter("@DeliveryNoteItemID", DbType.Int32, DeliveryNoteID);
            else
                dbHelper.SelectParameter("@DeliveryNoteItemID  ", DbType.Int32, DBNull.Value);

            DataTable dtDeliveryNoteDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_DeliveryNoteItem");
            return dtDeliveryNoteDetails;
        }
        public DataTable GetAllDeliveryNoteItemReport(int DeliveryNoteID, int DeliveryNoteItemID)
        {

            dbHelper.SelectParameterClear();
            if (DeliveryNoteID > 0)
                dbHelper.SelectParameter("@DeliveryNoteID", DbType.Int32, DeliveryNoteID);
            else
                dbHelper.SelectParameter("@DeliveryNoteID", DbType.Int32, DBNull.Value);

            if (DeliveryNoteItemID > 0)
                dbHelper.SelectParameter("@DeliveryNoteItemID", DbType.Int32, DeliveryNoteID);
            else
                dbHelper.SelectParameter("@DeliveryNoteItemID  ", DbType.Int32, DBNull.Value);

            DataTable dtDeliveryNoteDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_DeliveryNoteItem_Report");
            return dtDeliveryNoteDetails;
        }
        
        public bool DeliveryNoteSave(int DeliveryNoteID, string DeliveryNoteXML, string DeliveryNoteItemXML, int CreatedBy)
        {
            dbHelper.InsertUpdateDeleteParameter("@DeliveryNoteID", DbType.Int32, DeliveryNoteID);
            dbHelper.InsertUpdateDeleteParameter("@DeliveryNoteXML", DbType.Xml, DeliveryNoteXML);
            dbHelper.InsertUpdateDeleteParameter("@DeliveryNoteItemXML", DbType.Xml, DeliveryNoteItemXML);
            dbHelper.InsertUpdateDeleteParameter("@modifiedBy", DbType.Int32, CreatedBy);   
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spDeliveryNote_DeliveryNoteEntrySave");    
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
               
        public int getWorkingDaysinWeek(DateTime dtStartDate, DateTime dtEndDate, string tsProfileCode, string phProfileCode)
        {
            tsProfileCode = tsProfileCode.Replace("'", "''");
            phProfileCode = phProfileCode.Replace("'", "''");

            string strSQL = string.Format("select [SYSADM].[fn_GetWorkingDayCount]('{0}', '{1}', N'{2}', N'{3}') ",
                dtStartDate.ToString("yyyy/MM/dd"), dtEndDate.ToString("yyyy/MM/dd"), tsProfileCode, phProfileCode);

            return Convert.ToInt32(dbHelper.GetScalarValue(CommandType.Text, strSQL));
        }
               
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

