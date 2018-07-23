using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AC.Billing.DataAccess
{
    public class InvoiceDAL : BaseClassDAL
    {
        public InvoiceDAL(DBHelper _dbHelper)
            : base(_dbHelper)
        { }

        public DataTable GetProduct()
        {
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "Get_Product");
            return dtProductDetails;
        }

        public DataTable GetMaxInvoice()
        {
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetMax_Invoice");
            return dtProductDetails;
        }

      
        
        public DataTable GetAllPaymentMode()
        {
            DataTable dtPaymentModeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_PaymentMode");
            return dtPaymentModeDetails;
        }
        public DataTable GetAllInvoice(int invoiceID)
        {

            dbHelper.SelectParameterClear();
            if (invoiceID > 0)
                dbHelper.SelectParameter("@InvoiceID", DbType.Int32, invoiceID);
            else
                dbHelper.SelectParameter("@InvoiceID", DbType.Int32, DBNull.Value);
            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Invoice");
            return dtInvoiceDetails;
        }
        public DataTable GetInvoiceMonthlyReport(DateTime fromdate, DateTime todate)
        {

            dbHelper.SelectParameter("@FromDate", DbType.DateTime, fromdate);
            dbHelper.SelectParameter("@Todate", DbType.DateTime, todate);
            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "sp_GetMonthlyInvoiceReprot");
            return dtInvoiceDetails;
        }


        public DataTable GetAllInvoiceItem(int invoiceID, int invoiceItemID)
        {

            dbHelper.SelectParameterClear();
            if (invoiceID > 0)
                dbHelper.SelectParameter("@InvoiceID", DbType.Int32, invoiceID);
            else
                dbHelper.SelectParameter("@InvoiceID", DbType.Int32, DBNull.Value);

            if (invoiceItemID > 0)
                dbHelper.SelectParameter("@InvoiceItemID", DbType.Int32, invoiceItemID);
            else
                dbHelper.SelectParameter("@InvoiceItemID", DbType.Int32, DBNull.Value);

            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_InvoiceItem");
            return dtInvoiceDetails;
        }
        public DataTable GetAllInvoiceItemReport(int invoiceID, int invoiceItemID)
        {

            dbHelper.SelectParameterClear();
            if (invoiceID > 0)
                dbHelper.SelectParameter("@InvoiceID", DbType.Int32, invoiceID);
            else
                dbHelper.SelectParameter("@InvoiceID", DbType.Int32, DBNull.Value);

            if (invoiceItemID > 0)
                dbHelper.SelectParameter("@InvoiceItemID", DbType.Int32, invoiceItemID);
            else
                dbHelper.SelectParameter("@InvoiceItemID", DbType.Int32, DBNull.Value);

            DataTable dtInvoiceDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_InvoiceItem_Report");
            return dtInvoiceDetails;
        }
        

        public bool InvoiceSave(int invoiceID, string invoiceXML, string invoiceItemXML, int CreatedBy)
        {
            dbHelper.InsertUpdateDeleteParameter("@invoiceXML", DbType.Xml, invoiceXML);
            dbHelper.InsertUpdateDeleteParameter("@invoiceItemXML", DbType.Xml, invoiceItemXML);
            dbHelper.InsertUpdateDeleteParameter("@modifiedBy", DbType.Int32, CreatedBy);
            dbHelper.InsertUpdateDeleteParameter("@invoiceID", DbType.Int32, invoiceID);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spInvoice_InvoiceEntrySave");
            return true;
        }

        public bool InvoiceDelete(int invoiceID, int modifiedBy)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@Invoice", DbType.Int32, invoiceID);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, modifiedBy);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Invoice");

            return true;
        }



    }
}

