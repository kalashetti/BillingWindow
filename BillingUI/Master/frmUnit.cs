using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingUI;
using AC.Billing.Business;
using AC.Billing.DataAccess;
using System.Configuration;

namespace AC.Billing.UI.Master
{
    public partial class frmUnit : BaseClass
    {
        #region [Variable Declaration]       
        UnitBLL unitBll;
        ProductBLL productBLL;
        int sizeId, UserId = 1;

        #endregion [Variable Declaration]  
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                unitBll.UnitSave(sizeId, txtName.Text.Trim(), txtDesc.Text.Trim(), UserId);
                sizeId = 0;
                ClearFields();
                FillGrid();
            }
            else
            {
                MessageBox.Show("Please enter details.");
            }
        }
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
           

        }
       

        public frmUnit()
        {
            unitBll = new UnitBLL(dbHelper);
            productBLL = new ProductBLL(dbHelper);
            InitializeComponent();           
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }
        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = unitBll.GetAllUnit(null);
            GridBind(dt);
        }
        private void GridBind(DataTable dt)
        {

            dataGridView1.AutoGenerateColumns = false;
            dt.Columns.Add("Edit");
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;              

            }

        }

        private void frmSize_Load(object sender, EventArgs e)
        {
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width = 70;

			FillGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            var aa = dataGridView1.CurrentCell.RowIndex;
            sizeId = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 3 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                txtName.Text = dataGridView1.Rows[aa].Cells[1].Value.ToString();              
                txtDesc.Text = dataGridView1.Rows[aa].Cells[2].Value.ToString();
              

            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 4 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {

                bool check = unitBll.UnitDelete(sizeId, UserId);
                if (check == true)
                    MessageBox.Show("Selected Unit Deleted Successfully.");
                else
                    MessageBox.Show("Selected Unit cannot be deleted due to mapping with other masters.");
                sizeId = 0;
            }
            FillGrid();
        }
    }
}
