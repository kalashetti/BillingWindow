using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
    public class UserDAL : BaseClassDAL
    {
        public UserDAL(DBHelper _dbHelper)
            : base(_dbHelper)
        { }

        public DataTable GetUserDetails(string username , string password)
        {
           
            dbHelper.SelectParameterClear();
            dbHelper.SelectParameter("@UserName", DbType.String, username);
            dbHelper.SelectParameter("@Password", DbType.String, password);
            DataTable dtUser = dbHelper.GetDataInDataTable(CommandType.StoredProcedure, "Get_UserDetails");
            return dtUser;
        }

        /// <summary>
        /// UpdatePassword
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public int UpdatePassword(string userName, string newPassword) //string oldPassword,
        {
            dbHelper.SelectParameterClear();
            dbHelper.SelectParameter("@UserName", DbType.String, userName);
            //dbHelper.SelectParameter("@OldPassword", DbType.String, oldPassword);
            dbHelper.SelectParameter("@NewPassword", DbType.String, newPassword);
            object returnValue = dbHelper.GetScalarValue(CommandType.StoredProcedure, "usp_ChangePassword");
            return Convert.ToInt32(returnValue);
        }
    }
}
