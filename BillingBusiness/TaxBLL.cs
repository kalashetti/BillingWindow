using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;

namespace AC.Billing.Business
{
   public class TaxBLL : BaseClassBLL
    {
        TaxDAL taxDAL;
        public TaxBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            taxDAL = new TaxDAL(_dbHelper);
        }
        public DataTable GetAllTax(int ?taxID)
        {
            return taxDAL.GetAllTax(taxID);
        }
        public bool TaxSave(int TaxID, string Name, string Description, DateTime EffectiveFrom, int CreatedBy, decimal taxper)
        {
            return taxDAL.TaxSave(TaxID, Name, Description, EffectiveFrom, CreatedBy, taxper);
        }
        public bool DeleteTax(int TaxID, int UpdatedBy)
        {
            return taxDAL.DeleteTax(TaxID, UpdatedBy);
        }
        public override void Dispose()
        {
            taxDAL.Dispose();
        }
    }
}
