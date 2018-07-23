using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class ProductSubCategoryBLL : BaseClassBLL
    {
        ProductSubCategoryDAL productSubCategoryDAL;
        public ProductSubCategoryBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            productSubCategoryDAL = new ProductSubCategoryDAL(_dbHelper);
        }
        public DataTable GetAllProductSubCategory()
        {
            return productSubCategoryDAL.GetAllProductSubCategory();
        }

        public bool ProductSubCategorySave(int ProductSubCategoryID, int ProductCategoryID, string Name, string Description, DateTime UpdatedOn, int CreatedBy, int UpdatedBy)
        {
            return productSubCategoryDAL.ProductSubCategorySave(ProductSubCategoryID, ProductCategoryID, Name, Description, UpdatedOn, CreatedBy, UpdatedBy);
        }

        public DataTable GetAllProductSubCategoryWithCategory()
        {            
            return productSubCategoryDAL.GetAllProductSubCategoryWithCategory();            
        }

        public bool ProductSubCategoryDelete(int ProductSubCategoryID, DateTime UpdatedOn, int UpdatedBy)
        {
            return productSubCategoryDAL.ProductSubCategoryDelete(ProductSubCategoryID, UpdatedOn, UpdatedBy);
        }
        public override void Dispose()
        {
            productSubCategoryDAL.Dispose();
        }
    }
}
