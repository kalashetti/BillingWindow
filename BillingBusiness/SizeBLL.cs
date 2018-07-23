using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;

namespace AC.Billing.Business
{
    public class SizeBLL : BaseClassBLL
    {
        SizeDAL sizeDal;
        public SizeBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            sizeDal = new SizeDAL(_dbHelper);
        }
        public DataTable GetAllSize(int ? sizeID, int? unitId)
        {
            return sizeDal.GetAllSize(sizeID, unitId);
        }
        public bool SizeSave(int SizeId, string Name, string Description, int CreatedBy, int unitId)
        {
            return sizeDal.SizeSave(SizeId, Name, Description, CreatedBy, unitId);
        }
        public bool SizeDelete(int sizeId, int UpdatedBy)
        {
            return sizeDal.SizeDelete(sizeId, UpdatedBy);
        }
        public override void Dispose()
        {
            sizeDal.Dispose();
        }
    }
}
