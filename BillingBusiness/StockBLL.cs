using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;

namespace AC.Billing.Business
{
   public class StockBLL : BaseClassBLL
    {
        StockDAL stockDAL;
        StockReportDAL stockRepDAL;
        public StockBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            stockDAL = new StockDAL(_dbHelper);
            stockRepDAL = new StockReportDAL(_dbHelper);
        }
        public override void Dispose()
        {
            stockDAL.Dispose();
        }
        public DataTable GetAllStock(int? stckId)
        {
            return stockDAL.GetAllStock(stckId);
        }
        public bool StockDelete(int stockId, DateTime UpdatedOn, int UpdatedBy)
        {
            return stockDAL.StockDelete(stockId, UpdatedOn, UpdatedBy);
        }
        public bool StockSave(int StockID, int ProductID, string Make, int quantity, int Unit, int TaxID,
     int SizeID, decimal RatePerUnit, decimal tax, decimal taxamount, decimal Discount, decimal discountamt, decimal totalAmt, string Remark, Int32 CreatedBy)
        {
            return stockDAL.StockSave(StockID, ProductID, Make, quantity, Unit, TaxID, SizeID, RatePerUnit, tax, taxamount, Discount, discountamt, totalAmt, Remark, CreatedBy);
        }

        public DataTable GetAllProducts()
        {
            return stockRepDAL.GetAllProducts();

        }

        public DataTable GetAllMake()
        {
            return stockRepDAL.GetAllMake();
        }

        public DataTable GetStockReport(DateTime fromDate, DateTime toDate, int productID, string make)
        {
            return stockRepDAL.GetStockReport(fromDate, toDate, productID, make);

        }
    }
}
