using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AC.Billing.UI.Master;
using AC.Billing.UI.Transaction;
using BillingUI;
using System.Configuration;


namespace AC.Billing.UI
{
    public partial class MDIParent : BaseClass
    {
        public static int Form_Count;
        public MDIParent()
        {
            InitializeComponent();
        }
        protected override void OnResize(EventArgs e)
        {
            CenterForms();
            base.OnResize(e);
        }
        private void CenterForms()
        {
            foreach (var form in MdiChildren) //This will center all of the Child Forms
            {
                form.Left = (ClientRectangle.Width - form.Width) / 2;
                form.Top = (ClientRectangle.Height - form.Height) / 2;
            }

        }
        private void MDIParent_Load(object sender, EventArgs e)
        {
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width = 70;
		}
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmProductCategory obj = new frmProductCategory();
            obj.MdiParent = this;
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmProduct obj = new frmProduct();
            obj.MdiParent = this;
            obj.Hide();
            obj.Show();
        }


        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmUnit obj = new frmUnit();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //frmSize obj = new frmSize();
            //obj.MdiParent = this;
            //obj.Show();
        }



        private void tblStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmStock obj = new frmStock();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTax obj = new frmTax();
            obj.MdiParent = this;
            obj.Show();
        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice obj = new frmInvoice();
            obj.MdiParent = this;
            obj.Show();
            
        }

        private void deliveryNoteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmInvoiceItem obj = new frmInvoiceItem();
            //obj.MdiParent = this;
            //obj.Show();

        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliveryNote obj = new frmDeliveryNote();
            obj.MdiParent = this;
            obj.Show();


        }

        private void invoiceItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDeliveryNoteItem obj = new frmDeliveryNoteItem();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory obj = new Inventory();
            obj.MdiParent = this;
            obj.MaximizeBox = true;
            obj.MinimizeBox = true;
            //obj.Close = true;
            obj.Show();
        }

        private void inventoryItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmInventoryItem obj = new frmInventoryItem();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void quotetionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuotation obj = new frmQuotation();
            obj.MdiParent = this;
            obj.Show();
        }

        private void quotationItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmQuotationItem obj = new frmQuotationItem();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSubProductCategory obj = new frmSubProductCategory();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmInvoiceReport obj = new frmInvoiceReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private bool CheckOpened()
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if(frm.Text!="Billing")
                frm.Hide();               
            }
            return false;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize obj = new frmSize();
            obj.MdiParent = this;
            obj.Show();

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock obj = new frmStock();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {//inv

            frmInventryReport obj = new frmInventryReport();
            obj.MdiParent = this;
           
            obj.Show();
            
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmQuotationReport obj = new frmQuotationReport();
            obj.MdiParent = this;
            obj.Show();

        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmDeleveryNoteReport obj = new frmDeleveryNoteReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockReport obj = new frmStockReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void modalWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            //frm2.MdiParent = this;
            frm2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
