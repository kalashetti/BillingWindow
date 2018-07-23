using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Billing.DataAccess
{
    public abstract class BaseClassDAL : IDisposable
    {

        protected DBHelper dbHelper;
        internal BaseClassDAL(DBHelper _dbHelper)
        {
            dbHelper = _dbHelper;
        }
        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose()
        {

        }


        /// <summary>
        /// Begins the transaction.
        /// </summary>
        public void BeginTransaction()
        {
            dbHelper.BeginTransaction();
        }

        /// <summary>
        /// Commits the transaction.
        /// </summary>
        public void CommitTransaction()
        {
            dbHelper.CommitTransaction();
        }

        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        public void RollbackTransaction()
        {
            dbHelper.RollbackTransaction();
        }

        #endregion
    }
}
