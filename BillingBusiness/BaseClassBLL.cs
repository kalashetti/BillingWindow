using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
namespace AC.Billing.Business
{
    public abstract class BaseClassBLL : IDisposable
    {
        #region IDisposable Members
        public abstract void Dispose();

        protected DBHelper dbHelper;
        internal BaseClassBLL(DBHelper _dbHelper)
        {
            dbHelper = _dbHelper;
        }
      
        #endregion
    }
}
    