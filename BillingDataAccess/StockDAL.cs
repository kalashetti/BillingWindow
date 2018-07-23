using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
    public  class StockDAL : BaseClassDAL
    {
        public StockDAL(DBHelper _dbHelper)
             : base(_dbHelper)
        { }

        public DataTable GetAllStock(int? stckId)
        {
            dbHelper.SelectParameter("@StockID", DbType.Int32, stckId);
            DataTable dtProductDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Stock");
            return dtProductDetails;
        }
        public bool StockDelete(int stockId, DateTime UpdatedOn, int UpdatedBy)
        {
            string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@StockID", DbType.Int32, stockId);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedOn", DbType.DateTime, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, DBNull.Value);
            dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_tblStock", "@Check", out outvalue);
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

        public bool StockSave(int StockID, int ProductID, string Make,int quantity, int Unit, int TaxID,
       int SizeID, decimal RatePerUnit, decimal tax, decimal taxamount, decimal Discount,decimal discountamt, decimal  totalAmt, string Remark,  Int32 CreatedBy)
        {
            dbHelper.InsertUpdateDeleteParameter("@StockID", DbType.Int32, StockID);
            dbHelper.InsertUpdateDeleteParameter("@ProductID", DbType.Int32, ProductID);
            dbHelper.InsertUpdateDeleteParameter("@Make", DbType.String, Make);
            dbHelper.InsertUpdateDeleteParameter("@Quantity", DbType.Int32, quantity);
            dbHelper.InsertUpdateDeleteParameter("@UnitID", DbType.Int32, Unit);
            dbHelper.InsertUpdateDeleteParameter("@SizeID", DbType.Int32, SizeID);
            dbHelper.InsertUpdateDeleteParameter("@RatePerUnit", DbType.Decimal, RatePerUnit);
            dbHelper.InsertUpdateDeleteParameter("@TaxID", DbType.Int32, TaxID);
            dbHelper.InsertUpdateDeleteParameter("@Tax", DbType.Decimal, tax);
            dbHelper.InsertUpdateDeleteParameter("@TaxAmount", DbType.Decimal, taxamount);                        
            dbHelper.InsertUpdateDeleteParameter("@Discount", DbType.Decimal, Discount);
            dbHelper.InsertUpdateDeleteParameter("@DiscountAmount", DbType.Decimal, discountamt);
            dbHelper.InsertUpdateDeleteParameter("@TotalAmount", DbType.Decimal, totalAmt);
            dbHelper.InsertUpdateDeleteParameter("@Remark", DbType.String, Remark);        
            dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, CreatedBy);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spStock_StockEntrySave");

            return true;
        }
    }
}
