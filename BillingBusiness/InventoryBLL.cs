using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class InventoryBLL : BaseClassBLL
    {
        InventoryDAL inventoryDAL;

        public InventoryBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            inventoryDAL = new InventoryDAL(_dbHelper);
        }
        public DataTable GetMax_Inventory()
        {
            return inventoryDAL.GetMax_Inventory();
        }
        public bool DeleteInventory(int inventoryID, int modifiedBy)
        {
            return inventoryDAL.DeleteInventory(inventoryID, modifiedBy);
        }
        public DataTable GetInventoryReport(DateTime fromdate, DateTime todate)
        {

            return inventoryDAL.GetInventoryReport(fromdate, todate);
        }

        public DataTable GetAllPaymentMode()
        {
            return inventoryDAL.GetAllPaymentMode();
        }

        public DataTable GetProduct()
        {
            return inventoryDAL.GetProduct();
        }

        public DataTable GetAllInventory(int InventoryID)
        {
            return inventoryDAL.GetAllInventory(InventoryID);
        }

        public DataTable GetAllInventoryItem(int inventoryID, int inventoryItemID)
        {
            return inventoryDAL.GetAllInventoryItem(inventoryID, inventoryItemID);
        }
        public DataTable GetAllInventoryItemReport(int inventoryID, int inventoryItemID)
        {
            return inventoryDAL.GetAllInventoryItemReport(inventoryID, inventoryItemID);
        }

        public bool InventorySave(int InventoryID, string InventoryXML, string InventoryItemXML, int CreatedBy)
        {
            return inventoryDAL.InventorySave(InventoryID, InventoryXML, InventoryItemXML, CreatedBy);
        }


        public override void Dispose()
        {
            inventoryDAL.Dispose();
        }
    }
}
