using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class InvoiceBLL : BaseClassBLL
    {
        InvoiceDAL InvoiceDAL;
        public InvoiceBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            InvoiceDAL = new InvoiceDAL(_dbHelper);
        }
        public DataTable GetInvoiceMonthlyReport(DateTime fromdate, DateTime todate)
        {
            return InvoiceDAL.GetInvoiceMonthlyReport(fromdate, todate);
        }
        public DataTable GetAllInvoiceItemReport(int invoiceID, int invoiceItemID)
        {
            return InvoiceDAL.GetAllInvoiceItemReport(invoiceID, invoiceItemID);
        }
        public DataTable GetMaxInvoice()
        {
            return InvoiceDAL.GetMaxInvoice();
        }
        public DataTable GetProduct()
        {
            return InvoiceDAL.GetProduct();
        }
        public DataTable GetAllPaymentMode()
        {
            return InvoiceDAL.GetAllPaymentMode();
        }
        public DataTable GetAllInvoice(int invoiceID)
        {
            return InvoiceDAL.GetAllInvoice(invoiceID);
        }

        public DataTable GetAllInvoiceItem(int invoiceID, int invoiceItemID)
        {
            return InvoiceDAL.GetAllInvoiceItem(invoiceID, invoiceItemID);
        }

        public bool InvoiceSave(int invoiceID, string invoiceXML, string invoiceItemXML, int CreatedBy)
        {
            return InvoiceDAL.InvoiceSave(invoiceID, invoiceXML, invoiceItemXML, CreatedBy);
        }

        public bool InvoiceDelete(int invoiceId, int UpdatedBy)
        {
            return InvoiceDAL.InvoiceDelete(invoiceId, UpdatedBy);
        }
        public override void Dispose()
        {
            InvoiceDAL.Dispose();
        }
    }
}
