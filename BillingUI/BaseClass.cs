using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AC.Billing.DataAccess;
namespace BillingUI
{
    public class BaseClass : Form
    {
        private DBHelper _dbQuery;
        public DBHelper dbHelper
        {
            get
            {
                try
                {
                    if (_dbQuery == null)
                        _dbQuery = new DBHelper();
                    return _dbQuery;
                }
                catch (Exception ex)
                {
                    //string str = ex.Message;                    
                    throw;
                }

            }
        }

        public int USERID { get; set; }

        public bool ShowDeleteConfirmMessage()
        {
            bool isDelete = false;
            string message = "Do you want to delete this item?";
            string title = "Confirm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                isDelete = true;               
               // this.Close();
            }
            else
            {
                isDelete = false;
               // this.Close();
            }
            return isDelete;
        }
    }
}
