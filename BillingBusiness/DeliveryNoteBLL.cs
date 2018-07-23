using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC.Billing.DataAccess;
using System.Data;
namespace AC.Billing.Business
{
    public class DeliveryNoteBLL : BaseClassBLL    {
        DeliveryNoteDAL deliveryNoteDAL;

        public DeliveryNoteBLL(DBHelper _dbHelper)
            : base(_dbHelper)
        {
            deliveryNoteDAL = new DeliveryNoteDAL(_dbHelper);
        }
        public bool DeleteDeliveryNote(int deliveryNoteID, int modifiedBy)
        {
            return deliveryNoteDAL.DeleteDeliveryNote(deliveryNoteID, modifiedBy);
        }
        public DataTable GetDeliveryNoteReport(DateTime fromdate, DateTime todate)
        {

            return deliveryNoteDAL.GetDeliveryNoteReport(fromdate, todate);
        }
        public DataTable GetAllDeliveryMode()
        {
            return deliveryNoteDAL.GetAllDeliveryMode();
        }

        public DataTable GetProduct()
        {
            return deliveryNoteDAL.GetProduct();
        }

        public DataTable GetAllInvoice()
        {
            return deliveryNoteDAL.GetAllInvoice();
        }

        public DataTable GetAllDeliveryNote(int DeliveryNoteID)
        {
            return deliveryNoteDAL.GetAllDeliveryNote(DeliveryNoteID);
        }

        public DataTable GetAllDeliveryNoteItem(int DeliveryNoteID, int DeliveryNoteItemID)
        {
            return deliveryNoteDAL.GetAllDeliveryNoteItem(DeliveryNoteID, DeliveryNoteItemID);
        }
        public DataTable GetAllDeliveryNoteItemReport(int DeliveryNoteID, int DeliveryNoteItemID)
        {
            return deliveryNoteDAL.GetAllDeliveryNoteItemReport(DeliveryNoteID, DeliveryNoteItemID);
        }
        public bool DeliveryNoteSave(int DeliveryNoteID, string DeliveryNoteXML, string DeliveryNoteItemXML, int CreatedBy)
        {
            return deliveryNoteDAL.DeliveryNoteSave(DeliveryNoteID, DeliveryNoteXML, DeliveryNoteItemXML, CreatedBy);
        }


        public override void Dispose()
        {
            deliveryNoteDAL.Dispose();
        }


    }
}
