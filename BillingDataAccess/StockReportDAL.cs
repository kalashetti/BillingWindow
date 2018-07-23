using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AC.Billing.DataAccess
{
    public class StockReportDAL : BaseClassDAL
    {
        public StockReportDAL(DBHelper _dbHelper)
             : base(_dbHelper)
        { }


        public DataTable GetAllProducts()
        {
            string query = "SELECT ProductID,ProductName FROM tblProduct WHERE IsActive=1";
            //dbHelper.SelectParameter("@StockID", DbType.Int32, stckId);
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.Text, query);
            return dtProductDetails;

        }

        public DataTable GetAllMake()
        {
            string query = "SELECT DISTINCT(Make) FROM tblProduct WHERE IsActive=1";
            //dbHelper.SelectParameter("@StockID", DbType.Int32, stckId);
            DataTable dtMakeDetails = dbHelper.GetDataInDataTable(CommandType.Text, query);
            return dtMakeDetails;

        }

        public DataTable GetStockReport(DateTime fromdate,DateTime toDate,int productID, string make)
        {
            dbHelper.SelectParameter("@FromDate", DbType.DateTime, fromdate);
            dbHelper.SelectParameter("@ToDate", DbType.DateTime, toDate);
            dbHelper.SelectParameter("@ProductID", DbType.Int32, productID);
            dbHelper.SelectParameter("@Make", DbType.String, make);
            DataTable dtStockreport = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "usp_MonthlyStockReport");
            return dtStockreport;
        }

    }
}
