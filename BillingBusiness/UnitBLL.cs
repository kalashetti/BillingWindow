using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;

namespace AC.Billing.Business
{
    public class UnitBLL : BaseClassBLL
    {
        UnitDAL unitDAL;
        public UnitBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            unitDAL = new UnitDAL(_dbHelper);
        }
        public DataTable GetAllUnit(int? unitId)
        {
            return unitDAL.GetAllUnit(unitId);
        }
        public bool UnitSave(int unitId, string Name, string Description, int CreatedBy)
        {
            return unitDAL.UnitSave(unitId, Name, Description, CreatedBy);
        }
        public bool UnitDelete(int unitId, int UpdatedBy)
        {
            return unitDAL.UnitDelete(unitId, UpdatedBy);
        }
        public override void Dispose()
        {
            unitDAL.Dispose();
        }
    }
}
