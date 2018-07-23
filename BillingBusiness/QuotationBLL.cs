using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class QuotationBLL : BaseClassBLL    {
        QuotationDAL quotationDAL;

        public QuotationBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            quotationDAL = new QuotationDAL(_dbHelper);
        }
        public bool DeleteQuotation(int quotationID, int modifiedBy)
        {
            return quotationDAL.DeleteQuotation(quotationID, modifiedBy);
        }
        public DataTable GetAllPaymentMode()
        {
            return quotationDAL.GetAllPaymentMode();
        }
        public DataTable GetQuotationReport(DateTime fromdate, DateTime todate)
        {
            return quotationDAL.GetQuotationReport(fromdate, todate);
        }

        public DataTable GetProduct()
        {
            return quotationDAL.GetProduct();
        }

        public DataTable GetAllQuotationItemReport(int QuotationID, int QuotationItemID)
        {
            return quotationDAL.GetAllQuotationItemReport(QuotationID, QuotationItemID);
        }
        public DataTable GetAllQuotation(int QuotationID)
        {
            return quotationDAL.GetAllQuotation(QuotationID);
        }

        public DataTable GetAllQuotationItem(int QuotationID, int QuotationItemID)
        {
            return quotationDAL.GetAllQuotationItem(QuotationID, QuotationItemID);
        }

        public bool QuotationSave(int QuotationID, string QuotationXML, string QuotationItemXML, int CreatedBy)
        {
            return quotationDAL.QuotationSave(QuotationID, QuotationXML, QuotationItemXML, CreatedBy);
        }


        public override void Dispose()
        {
            quotationDAL.Dispose();
        }


    }
}
