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
    public partial class frmProductCategory : BaseClass
    {
        #region [Variable Declaration]       
        ProductCategoryBLL productCategoryBLL;
        int ProductCategoryID, UserId = 1;

        #endregion [Variable Declaration]  

        #region [Events] 

        public frmProductCategory()
        {
            productCategoryBLL = new ProductCategoryBLL(dbHelper);
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }

        private void frmProductCategory_Load(object sender, EventArgs e)
        {

			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 66;
			pictureBox1.Width = 84;

			Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
            FillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                int HSN = 0;
                if (!string.IsNullOrEmpty(txtHSN.Text.Trim()))
                {
                    HSN = Convert.ToInt32(txtHSN.Text.Trim());
                }
                productCategoryBLL.ProductCategorySave(ProductCategoryID, txtName.Text.Trim(), txtDesc.Text.Trim(), DateTime.Now, null, null, HSN);
                ProductCategoryID = 0;
                ClearFields();
                FillGrid();
            }
        }
        public void onlynumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void txHSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumber(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            var aa = dataGridView1.CurrentCell.RowIndex;
            ProductCategoryID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 4 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                txtName.Text = dataGridView1.Rows[aa].Cells[1].Value.ToString();
                txtHSN.Text = dataGridView1.Rows[aa].Cells[2].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[aa].Cells[3].Value.ToString();
            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 5 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                ProductCategoryID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
                bool check = productCategoryBLL.ProductCategoryDelete(ProductCategoryID, DateTime.Now, UserId);
                if (check == true)
                    MessageBox.Show("Selected Product Category Deleted Successfully.");
                else
                    MessageBox.Show("Selected product category cannot be deleted due to mapping with other masters.");
                ProductCategoryID = 0;
            }
            FillGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        #endregion [Events] 

        #region [Fill Grid] 

        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = productCategoryBLL.GetAllProductCategory();
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

        #endregion [Fill Grid] 

        #region [Clear Fields] 
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtHSN.Text = string.Empty;

        }
        #endregion [Clear Fields] 

        #region [Validation] 

        private bool validation()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter Name");
                txtName.Focus();
                return false;
            }


            return true;
        }
        #endregion [Validation] 


    }

}

