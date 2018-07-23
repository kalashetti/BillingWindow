using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AC.Billing.DataAccess
{
    public class QuotationDAL : BaseClassDAL
    {
        public QuotationDAL(DBHelper _dbHelper) 
            : base(_dbHelper)
        {
        }
        public bool DeleteQuotation(int quotationID, int modifiedBy)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@QuotationID", DbType.Int32, quotationID);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, modifiedBy);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Quotation");

            return true;
        }
        public DataTable GetQuotationReport(DateTime fromdate, DateTime todate)
        {

            dbHelper.SelectParameter("@FromDate", DbType.DateTime, fromdate);
            dbHelper.SelectParameter("@Todate", DbType.DateTime, todate);
            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "sp_GetMonthlytblQuotationReport");
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

        public DataTable GetAllQuotation(int QuotationID)
        {
            
            dbHelper.SelectParameterClear();
            if (QuotationID > 0)
                dbHelper.SelectParameter("@QuotationID", DbType.Int32, QuotationID);
            else
                dbHelper.SelectParameter("@QuotationID", DbType.Int32, DBNull.Value);
            DataTable dtQuotationDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Quotation");
            return dtQuotationDetails;
        }
             

        public DataTable GetAllQuotationItem(int QuotationID, int QuotationItemID)
        {

            dbHelper.SelectParameterClear();
            if (QuotationID > 0)
                dbHelper.SelectParameter("@QuotationID", DbType.Int32, QuotationID);
            else
                dbHelper.SelectParameter("@QuotationID", DbType.Int32, DBNull.Value);

            if (QuotationItemID > 0)
                dbHelper.SelectParameter("@QuotationItemID", DbType.Int32, QuotationID);
            else
                dbHelper.SelectParameter("@QuotationItemID  ", DbType.Int32, DBNull.Value);

            DataTable dtQuotationDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_QuotationItem");
            return dtQuotationDetails;
        }
        public DataTable GetAllQuotationItemReport(int QuotationID, int QuotationItemID)
        {

            dbHelper.SelectParameterClear();
            if (QuotationID > 0)
                dbHelper.SelectParameter("@QuotationID", DbType.Int32, QuotationID);
            else
                dbHelper.SelectParameter("@QuotationID", DbType.Int32, DBNull.Value);

            if (QuotationItemID > 0)
                dbHelper.SelectParameter("@QuotationItemID", DbType.Int32, QuotationID);
            else
                dbHelper.SelectParameter("@QuotationItemID  ", DbType.Int32, DBNull.Value);

            DataTable dtQuotationDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Quotation_Report");
            return dtQuotationDetails;
        }
        
        public bool QuotationSave(int QuotationID, string QuotationXML, string QuotationItemXML, int CreatedBy)
        {
            dbHelper.InsertUpdateDeleteParameter("@QuotationID", DbType.Int32, QuotationID);
            dbHelper.InsertUpdateDeleteParameter("@QuotationXML", DbType.Xml, QuotationXML);
            dbHelper.InsertUpdateDeleteParameter("@QuotationItemXML", DbType.Xml, QuotationItemXML);
            dbHelper.InsertUpdateDeleteParameter("@modifiedBy", DbType.Int32, CreatedBy);   
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spQuotation_QuotationEntrySave");    
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

