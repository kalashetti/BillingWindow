using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AC.Billing.DataAccess
{
  public  class UnitDAL: BaseClassDAL
    {

        public UnitDAL(DBHelper _dbHelper)
          : base(_dbHelper)
        { }


        public DataTable GetAllUnit(int? unitId)
        {
            dbHelper.SelectParameter("@UnitID", DbType.Int32, unitId);
            DataTable dtSizeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Unit");
            return dtSizeDetails;
        }
        public bool UnitSave(int unitid, string Name, string Description, int CreatedBy)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@UnitID", DbType.Int32, unitid);
            dbHelper.InsertUpdateDeleteParameter("@Name", DbType.String, Name);
            dbHelper.InsertUpdateDeleteParameter("@Description", DbType.String, Description);
            dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, CreatedBy);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "InsertUpdate_Unit");
            return true;
        }

        public bool UnitDelete(int unitid, int UpdatedBy)
        {
            string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();

            dbHelper.InsertUpdateDeleteParameter("@UnitID", DbType.Int32, unitid);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, UpdatedBy);
            dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Unit", "@Check", out outvalue);
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
