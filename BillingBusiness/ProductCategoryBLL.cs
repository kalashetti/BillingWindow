using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class ProductCategoryBLL : BaseClassBLL
    {
        ProductCategoryDAL productCategoryDAL;
        public ProductCategoryBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            productCategoryDAL = new ProductCategoryDAL(_dbHelper);
        }
        public DataTable GetAllProductCategory()
        {
            return productCategoryDAL.GetAllProductCategory();
        }

        public bool ProductCategorySave(int ProductCategoryID, string Name, string Description,DateTime UpdatedOn, string CreatedBy, string UpdatedBy,int HSN_SAC)
        {
            return productCategoryDAL.ProductCategorySave(ProductCategoryID, Name, Description,UpdatedOn, CreatedBy, UpdatedBy, HSN_SAC);
        }

        public bool ProductCategoryDelete(int ProductCategoryID,  DateTime UpdatedOn, int UpdatedBy)
        {
            return productCategoryDAL.ProductCategoryDelete(ProductCategoryID,UpdatedOn,UpdatedBy);
        }

        public override void Dispose()
        {
            productCategoryDAL.Dispose();
        }
    }
}
