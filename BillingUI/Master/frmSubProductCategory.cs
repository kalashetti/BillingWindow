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
    public partial class frmSubProductCategory : BaseClass
    {

        #region [Variable Declaration]       
        ProductSubCategoryBLL productSubCategoryBLL;
        ProductCategoryBLL productCategoryBLL;
        int ProductSubCategoryID,UserId=1;
        #endregion [Variable Declaration]  

        #region [Events] 
        public frmSubProductCategory()
        {
            productSubCategoryBLL = new ProductSubCategoryBLL(dbHelper);
            productCategoryBLL = new ProductCategoryBLL(dbHelper);
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            FillGrid();
            GetAllProductCategory();
        }

        private void frmSubProductCategory_Load(object sender, EventArgs e)
        {
			// productSubCategoryBLL.GetAllProductSubCategory();

			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 66;
			pictureBox1.Width = 84;
		}

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (validation() == true)
            {
                productSubCategoryBLL.ProductSubCategorySave(ProductSubCategoryID, Convert.ToInt32(cmbProductCategory.SelectedValue.ToString()), txtName.Text.Trim(), txtDesc.Text.Trim(), DateTime.Now, UserId, UserId);
            }
            ProductSubCategoryID = 0;
            ClearFields();
            FillGrid();
            GetAllProductCategory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            var aa = dataGridView1.CurrentCell.RowIndex;
            ProductSubCategoryID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 5 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                cmbProductCategory.SelectedValue = Convert.ToInt32(dataGridView1.Rows[aa].Cells[1].Value);
                txtName.Text = dataGridView1.Rows[aa].Cells[3].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[aa].Cells[4].Value.ToString();
            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 6 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                ProductSubCategoryID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
                bool check = productSubCategoryBLL.ProductSubCategoryDelete(ProductSubCategoryID, DateTime.Now, UserId);
                if (check == true)
                    MessageBox.Show("Selected Product Subcategory Deleted Successfully.");
                else
                    MessageBox.Show("Selected product Subcategory cannot be deleted due to mapping with other masters.");
                ProductSubCategoryID = 0;
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
            dt = productSubCategoryBLL.GetAllProductSubCategoryWithCategory();
            GridBind(dt);
        }
        
        private void GridBind(DataTable dt)
        {

            dataGridView1.AutoGenerateColumns = false;
            dt.Columns.Add("Edit");
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
            }

        }
        #endregion [Fill Grid] 

        #region [Combo Fill] 
        private void GetAllProductCategory()
        {
            DataTable dt = new DataTable();
            dt = productCategoryBLL.GetAllProductCategory();            
            cmbProductCategory.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select", "Select" });
            dt.DefaultView.Sort = "ProductCategoryID";
            cmbProductCategory.ValueMember = "ProductCategoryID";
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.SelectedValue = 0;
        }
        #endregion [Combo Fill] 

        #region [Clear Fields] 
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;

        }
        #endregion [Clear Fields] 

        #region [Validation] 

        private bool validation()
        {
            if ((string.IsNullOrEmpty(cmbProductCategory.SelectedValue.ToString())) || (cmbProductCategory.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Category");
                cmbProductCategory.Focus();
                return false;
            }

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
