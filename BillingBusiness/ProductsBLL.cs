using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class ProductsBLL:BaseClassBLL
    {
        ProductsDAL productsDAL;
        public ProductsBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            productsDAL = new ProductsDAL(_dbHelper);
        }
        public DataTable GetyProducts()
        {
            return productsDAL.GetAllProduct();
        }
        public override void Dispose()
        {
            productsDAL.Dispose();
        }
    }
}
