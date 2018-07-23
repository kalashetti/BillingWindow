using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AC.Billing.DataAccess
{
   public class SizeDAL: BaseClassDAL
    {

        public SizeDAL(DBHelper _dbHelper)
          : base(_dbHelper)
        { }


        public DataTable GetAllSize(int? sizeId, int ? unitId)
        {
            
            dbHelper.SelectParameter("@SizeID", DbType.Int32, sizeId);
            dbHelper.SelectParameter("@UnitID", DbType.Int32, unitId);
            DataTable dtSizeDetails = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "GetAll_Size");
            return dtSizeDetails;
        }


        public bool SizeSave(int SizeId, string Name,string Description,int CreatedBy, int unitID)
        {
            dbHelper.InsertUpdateDeleteParameterClear();
            dbHelper.InsertUpdateDeleteParameter("@SizeID", DbType.Int32, SizeId);
            dbHelper.InsertUpdateDeleteParameter("@SizeName", DbType.String, Name);
            dbHelper.InsertUpdateDeleteParameter("@SizeDescription", DbType.String, Description);
            dbHelper.InsertUpdateDeleteParameter("@CreatedBy", DbType.Int32, CreatedBy);
            dbHelper.InsertUpdateDeleteParameter("@UnitID", DbType.Int32, unitID);            
           
            if (dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "InsertUpdate_Size")>0)
               return true;
            else
                return false;

        }

        public bool SizeDelete(int sizeId, int UpdatedBy)
        {
            string outvalue = "0";
            dbHelper.InsertUpdateDeleteParameterClear();

            dbHelper.InsertUpdateDeleteParameter("@SizeID", DbType.Int32, sizeId);
            dbHelper.InsertUpdateDeleteParameter("@UpdatedBy", DbType.Int32, UpdatedBy);
            dbHelper.InsertUpdateDeleteParameter("@Check", DbType.String, 0, true);
            dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "Delete_Size", "@Check", out outvalue);
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
