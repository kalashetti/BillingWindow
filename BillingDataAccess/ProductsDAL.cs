using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
   public class ProductsDAL:BaseClassDAL
    {
       public ProductsDAL(DBHelper _dbHelper)
            : base(_dbHelper)
        { }

       /// <summary>
       /// Sample inline Query return data set.
       /// </summary>
       /// <returns></returns>
       public DataTable GetAllProduct()
       {          
          string strQuery = " ";          
           dbHelper.SelectParameterClear();
           return dbHelper.GetDataInDataTable(CommandType.Text, strQuery);
       }

       /// <summary>
       /// Sample sp query retrun data set
       /// </summary>
       /// <param name="leave_Code"></param>
       /// <param name="employee_Id"></param>
       /// <returns></returns>
       public DataSet GetAllProduct(string leave_Code, int employee_Id)
       {
           dbHelper.SelectParameterClear();
           dbHelper.SelectParameter("", DbType.String, leave_Code);
           dbHelper.SelectParameter("", DbType.String, employee_Id);
           DataSet dtLeaveCodeDetails = dbHelper.GetDataInDataSet(CommandType.StoredProcedure, "spName");
           return dtLeaveCodeDetails;
       }

       /// <summary>
       /// Simple product save or update
       /// </summary>
       /// <param name="leaveCode"></param>
       /// <param name="leaveDesc"></param>
       /// <param name="isBFAllowed"></param>
       /// <param name="daysBF"></param>
       /// <param name="isProbationCheck"></param>
       /// <param name="isAttachReq"></param>
       /// <param name="dispOnDashboard"></param>
       /// <param name="xmlLeaveParameters"></param>
       /// <param name="modifiedBy"></param>
       /// <returns></returns>
       public bool ProductSave(string leaveCode, string leaveDesc, bool isBFAllowed, string daysBF, bool isProbationCheck, bool isAttachReq, bool dispOnDashboard, string xmlLeaveParameters, string modifiedBy)
       {
           dbHelper.InsertUpdateDeleteParameterClear();
           dbHelper.InsertUpdateDeleteParameter("@LEAVE_CODE", DbType.String, leaveCode);
           dbHelper.InsertUpdateDeleteParameter("@LEAVE_DESC", DbType.String, leaveDesc);
           dbHelper.InsertUpdateDeleteParameter("@IS_BF_ALLOWED", DbType.Boolean, isBFAllowed);
           if (daysBF == string.Empty)
               dbHelper.InsertUpdateDeleteParameter("@DAYS_BF", DbType.Decimal, DBNull.Value);
           else
               dbHelper.InsertUpdateDeleteParameter("@DAYS_BF", DbType.Decimal, Convert.ToDecimal(daysBF));
           dbHelper.InsertUpdateDeleteParameter("@PROBATION_CHECK", DbType.Boolean, isProbationCheck);
           dbHelper.InsertUpdateDeleteParameter("@IS_ATTACH_REQD", DbType.Boolean, isAttachReq);
           dbHelper.InsertUpdateDeleteParameter("@DISP_ON_DASHBOARD", DbType.Boolean, dispOnDashboard);
           dbHelper.InsertUpdateDeleteParameter("@XMLLEAVEPARAMETER", DbType.String, xmlLeaveParameters);
           dbHelper.InsertUpdateDeleteParameter("@MODIFIED_BY", DbType.String, modifiedBy);
           dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spName");

           return true;
       }

       /// <summary>
       /// Simple product for delete
       /// </summary>
       /// <param name="modifiedBy"></param>
       /// <param name="leaveCode"></param>
       /// <returns></returns>
       public bool ProductDelete(string modifiedBy, string leaveCode)
       {
           dbHelper.InsertUpdateDeleteParameterClear();
           dbHelper.InsertUpdateDeleteParameter("@MODIFIED_BY", DbType.String, modifiedBy);
           dbHelper.InsertUpdateDeleteParameter("@LEAVE_CODE", DbType.String, leaveCode);
           dbHelper.InsertUpdateDeleteQuery(CommandType.StoredProcedure, "spName");

           return true;
       }

       /// <summary>
       /// return scalre value from inline 
       /// </summary>
       /// <param name="dtStartDate"></param>
       /// <param name="dtEndDate"></param>
       /// <param name="tsProfileCode"></param>
       /// <param name="phProfileCode"></param>
       /// <returns></returns>
       public int getWorkingDaysinWeek(DateTime dtStartDate, DateTime dtEndDate, string tsProfileCode, string phProfileCode)
       {
           tsProfileCode = tsProfileCode.Replace("'", "''");
           phProfileCode = phProfileCode.Replace("'", "''");

           string strSQL = string.Format("select [SYSADM].[fn_GetWorkingDayCount]('{0}', '{1}', N'{2}', N'{3}') ",
               dtStartDate.ToString("yyyy/MM/dd"), dtEndDate.ToString("yyyy/MM/dd"), tsProfileCode, phProfileCode);

           return Convert.ToInt32(dbHelper.GetScalarValue(CommandType.Text, strSQL));
       }
       /// <summary>
       /// return scalre value from sp 
       /// </summary>
       /// <param name="xmlAgencyDets"></param>
       /// <param name="userId"></param>
       /// <returns></returns>
       public string TESetupUpdate(string xmlAgencyDets, string userId)
       {
           dbHelper.SelectParameterClear();
           dbHelper.SelectParameter("@xmlAgencyDets", DbType.String, xmlAgencyDets);
           dbHelper.SelectParameter("@ModifiedBy", DbType.String, userId);

           string strNotUpdatedAgencies = (string)dbHelper.GetScalarValue(CommandType.StoredProcedure,"spName");
           return strNotUpdatedAgencies;
       }
    }
}
