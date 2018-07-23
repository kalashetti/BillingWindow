using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AC.Billing.DataAccess
{
  public  class TaxDAL : BaseClassDAL
    {
        public TaxDAL(DBHelper _dbHelper)
          : base(_dbHelper)
        { }

        public DataTable GetAllTax(int? taxID)
        {
            dbHelper.SelectParameter("@TaxID", DbType.Int32, taxID);
            DataTable dtSizeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Tax");
            return dtSizeDetails;
        }


        public bool TaxSave(int TaxID, string Name, string Description, DateTime EffectiveFrom, int CreatedBy, decimal taxper)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@TaxID", DbType.Int32, TaxID);
            dbHelper.InsertUpdateDeleteParameter("@TaxName", DbType.String, Name);
            dbHelper.InsertUpdateDeleteParameter("@TaxPercentage", DbType.Decimal, taxper);
            dbHelper.InsertUpdateDeleteParameter("@Description", DbType.String, Description);            
            dbHelper.InsertUpdateDeleteParameter("@EffectiveFrom", DbType.DateTime, EffectiveFrom);
            dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, CreatedBy);
          
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "InsertUpdate_Tax");

            return true;
        }

        public bool DeleteTax(int TaxID, int UpdatedBy)
        {
             string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();

            dbHelper.InsertUpdateDeleteParameter("@TaxID", DbType.Int32, TaxID);         
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, UpdatedBy);
            dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Tax", "@Check", out outvalue);
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
