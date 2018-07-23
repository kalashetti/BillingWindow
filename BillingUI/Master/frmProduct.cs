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
    public partial class frmProduct : BaseClass
    {

        #region [Variable Declaration]       
        ProductBLL productBLL;
        ProductSubCategoryBLL productSubCategoryBLL;
        ProductCategoryBLL productCategoryBLL;
        SizeBLL sizeBLL;
        int ProductID;
        #endregion [Variable Declaration]  
                
        #region [Events] 

        public frmProduct()
        {
            productBLL = new ProductBLL(dbHelper);
            sizeBLL = new SizeBLL(dbHelper);
            productSubCategoryBLL = new ProductSubCategoryBLL(dbHelper);
            productCategoryBLL = new ProductCategoryBLL(dbHelper);
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            FillGrid();
            FillCombo();
        }

        private void frmProduct_Load(object sender, EventArgs e)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (validation()==true)
            {
                productBLL.ProductSave(ProductID, Convert.ToInt32(cmbProductCategory.SelectedValue.ToString()), Convert.ToInt32(cmbSubCategory.SelectedValue.ToString()),
                    txtProduct.Text.Trim(), txtDescription.Text.Trim(), txtMake.Text.Trim(), cbUnit.SelectedText.Trim(), Convert.ToInt32(cmbTax.SelectedValue.ToString()),
                    Convert.ToInt32(cmbSize.SelectedValue.ToString()), Convert.ToDecimal(txtRate.Text.Trim()), txtDiscount.Text.Trim(), txtRemark.Text.Trim(),DateTime.Now,
                    USERID, USERID, Convert.ToInt32(cbUnit.SelectedValue.ToString()));
                ProductID = 0;
                ClearFields();
                FillGrid();
                FillCombo();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            var aa = dataGridView1.CurrentCell.RowIndex;
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 17 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                ProductID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
                                
                cmbProductCategory.SelectedValue = Convert.ToInt32(dataGridView1.Rows[aa].Cells[1].Value);
                if(dataGridView1.Rows[aa].Cells[2].Value!=null &&Convert.ToString(dataGridView1.Rows[aa].Cells[2].Value)!="")
                cmbSubCategory.SelectedValue = Convert.ToInt32(dataGridView1.Rows[aa].Cells[2].Value);
                else
                    cmbSubCategory.SelectedIndex = 0;
                cmbTax.SelectedValue = Convert.ToInt32(dataGridView1.Rows[aa].Cells[3].Value);
               
                cbUnit.SelectedValue = Convert.ToInt32(dataGridView1.Rows[aa].Cells[16].Value.ToString());
                GetAllSize(Convert.ToInt32(dataGridView1.Rows[aa].Cells[16].Value.ToString()));
                cmbSize.SelectedValue = Convert.ToInt32(dataGridView1.Rows[aa].Cells[4].Value);
                txtProduct.Text = dataGridView1.Rows[aa].Cells[7].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[aa].Cells[9].Value.ToString();
                txtMake.Text = dataGridView1.Rows[aa].Cells[8].Value.ToString();               
                txtRate.Text = dataGridView1.Rows[aa].Cells[13].Value.ToString();
                txtDiscount.Text = dataGridView1.Rows[aa].Cells[14].Value.ToString();
                txtRemark.Text = dataGridView1.Rows[aa].Cells[15].Value.ToString();
               

            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 18 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                ProductID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
                bool check = productBLL.ProductDelete(ProductID, DateTime.Now, USERID);
                if (check == true)
                    MessageBox.Show("Selected Product Deleted Successfully.");
                else
                    MessageBox.Show("Selected product cannot be deleted due to mapping with other masters.");
                ProductID = 0;
            }
            FillGrid();

        }

      
        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
            dt = productBLL.GetAllProduct(null);
            GridBind(dt);
        }
        
        private void GridBind(DataTable dt)
        {

            dataGridView1.AutoGenerateColumns = false;
            dt.Columns.Add("Edit");
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[7].ReadOnly = true;
                dataGridView1.Columns[8].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;
                dataGridView1.Columns[10].ReadOnly = true;
                dataGridView1.Columns[11].ReadOnly = true;
                dataGridView1.Columns[12].ReadOnly = true;
                dataGridView1.Columns[13].ReadOnly = true;
                dataGridView1.Columns[14].ReadOnly = true;
                dataGridView1.Columns[15].ReadOnly = true;
                
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

        private void GetAllProductSubCategory(string prodcutCat)
        {
            int? pCatID = null;
            if (prodcutCat == "0")
            {
                pCatID = null;
                cmbSubCategory.DataSource = null;
            }
            else
            {
                pCatID = Convert.ToInt32(prodcutCat);
                DataTable dt = new DataTable();
                dt = productBLL.GetAllSubCategory(null, pCatID);
                cmbSubCategory.DataSource = dt;
                dt.Rows.Add(new object[] { 0, "Select", "Select" });
                dt.DefaultView.Sort = "ProductSubCategoryID";
                cmbSubCategory.ValueMember = "ProductSubCategoryID";
                cmbSubCategory.DisplayMember = "SubCategoryName";
                cmbSubCategory.SelectedValue = 0;
            }
            
        }

        private void GetAllSize(int ? unitId)
        {
            DataTable dt = new DataTable();
            dt = sizeBLL.GetAllSize(null, unitId);
            cmbSize.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select", "Select" });
            dt.DefaultView.Sort = "SizeID";
            cmbSize.ValueMember = "SizeID";
            cmbSize.DisplayMember = "SizeName";
            cmbSize.SelectedValue = 0;
        }
        private void GetAllUnit()
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllUnit(null);
            cbUnit.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select", "Select" });
            dt.DefaultView.Sort = "UnitID";
            cbUnit.ValueMember = "UnitID";
            cbUnit.DisplayMember = "Name";
            cbUnit.SelectedValue = 0;
        }

        private void GetAllTax()
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllTax(null);
            cmbTax.DataSource = dt;
          //  dt.Rows.Add(new object[] { 0, "Select", "Select" });
           // dt.DefaultView.Sort = "TaxID";
            cmbTax.ValueMember = "TaxID";
            cmbTax.DisplayMember = "TaxName";
            cmbTax.SelectedValue = 0;
        }

        private void FillCombo()
        {
            GetAllProductCategory();          
            GetAllTax();
            GetAllUnit();
        }

        #endregion [Combo Fill] 

        #region [Clear Fields] 
        private void ClearFields()
        {
            txtProduct.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDiscount.Text = "0";
            txtMake.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtRemark.Text = string.Empty;
            cbUnit.SelectedValue = 0;
            cmbSize.DataSource = null;
            cmbSubCategory.SelectedValue = 0;
            cmbProductCategory.SelectedValue = 0;
            cmbTax.SelectedValue = 0;
        }

     
        #endregion [Clear Fields] 

        #region [Validation] 

        private bool validation()
        {
            if (string.IsNullOrEmpty(txtProduct.Text.Trim()))
            {
                MessageBox.Show("Please enter Product");
                txtProduct.Focus();
                return false;
            }
            
           

            if ((string.IsNullOrEmpty(cmbProductCategory.SelectedValue.ToString())) || (cmbProductCategory.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Category");
                cmbProductCategory.Focus();
                return false;
            }
          
            
            if (string.IsNullOrEmpty(txtMake.Text.Trim()))
            {
                MessageBox.Show("Please enter Make");
                txtMake.Focus();
                return false;
            }


            if ((string.IsNullOrEmpty(cbUnit.SelectedValue.ToString())) || (cbUnit.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please enter Unit");
                cbUnit.Focus();
                return false;
            }

            if ((string.IsNullOrEmpty(cmbSize.SelectedValue.ToString())) || (cmbSize.SelectedValue.ToString() == "0"))
            {
				MessageBox.Show("Please Select Size");
				cmbSize.Focus();
				return false;
			}

            if (string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                MessageBox.Show("Please enter Discount");
                txtDiscount.Focus();
                return false;
            }


            if ((string.IsNullOrEmpty(cmbTax.SelectedValue.ToString())) || (cmbTax.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Tax");
                cmbSize.Focus();
                return false;
            }

           
            if (string.IsNullOrEmpty(txtRate.Text.Trim()))
            {
                MessageBox.Show("Please enter Rate");
                txtRate.Focus();
                return false;
            }         

         
            

         

           
            if ((string.IsNullOrEmpty(cmbTax.SelectedValue.ToString())) || (cmbTax.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Tax");
                cmbTax.Focus();
                return false;
            }

            return true;
        }
        #endregion [Validation] 

        private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllProductSubCategory(cmbProductCategory.SelectedValue.ToString());
        }
        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int unitId = 0;
            int.TryParse(cbUnit.SelectedValue.ToString(), out unitId);
            if (unitId > 0)
            {
                GetAllSize(Convert.ToInt32(cbUnit.SelectedValue));
            }
        }
    }
}
