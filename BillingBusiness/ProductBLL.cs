using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class ProductBLL : BaseClassBLL
    {
        ProductDAL ProductDAL;
        public ProductBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            ProductDAL = new ProductDAL(_dbHelper);
        }
        public DataTable GetAllProduct(int?productId)
        {
            return ProductDAL.GetAllProduct(productId);
        }

        public DataTable GetAllSubCategory(int? ProductSubCategoryID, int? ProductCategoryID)
        {
            return ProductDAL.GetAllSubCategory(ProductSubCategoryID, ProductCategoryID);
        }

        public DataTable GetAllSize(int ?sizeID)
        {
            return ProductDAL.GetAllSize(sizeID);
        }
        public DataTable GetAllUnit(int? unitId)
        {
            return ProductDAL.GetAllUnit(unitId);
        }
        public DataTable GetAllTax(int ?taxID)
        { 
            return ProductDAL.GetAllTax(taxID);
        }

        public bool ProductSave(int ProductID, int ProductCategoryID, int ProductSubCategoryID,string ProductName, string ProductDescription,string Make,string Unit,int TaxID,
            int SizeID,decimal RatePerUnit,string Discount,string Remark, DateTime UpdatedOn, Int32 CreatedBy, Int32 UpdatedBy,int unitid)
        {
            return ProductDAL.ProductSave( ProductID, ProductCategoryID,ProductSubCategoryID,  ProductName,  ProductDescription,  Make, Unit,  TaxID,
             SizeID,  RatePerUnit,  Discount,  Remark, UpdatedOn, CreatedBy, UpdatedBy, unitid);
        }

        public bool ProductDelete(int ProductID, DateTime UpdatedOn, int UpdatedBy)
        {
            return ProductDAL.ProductDelete(ProductID, UpdatedOn, UpdatedBy);
        }
        public override void Dispose()
        {
            ProductDAL.Dispose();
        }
    }
}
