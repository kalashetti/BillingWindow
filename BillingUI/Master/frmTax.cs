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
    public partial class frmTax : BaseClass
    {
        #region [Variable Declaration]       
        TaxBLL taxBLL;
        int taxID, UserId = 1;

        #endregion [Variable Declaration]  
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                taxBLL.TaxSave(taxID, txtName.Text.Trim(), txtDesc.Text.Trim(), Convert.ToDateTime(dtEffectiveDate.Text), UserId, Convert.ToDecimal(txtPer.Text));
                taxID = 0;
                ClearFields();
                FillGrid();
            }
        }
        private bool validation()
        {
            

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter tax Name");
                txtName.Focus();
                return false;
            }
            decimal value;
            if (!Decimal.TryParse(txtPer.Text, out value))
            {
                MessageBox.Show("Please enter valid tax Percentage.Please enter value without '%'");
                txtPer.Focus();
                return false;
            }

            if (txtPer.Text.Trim().Length > 0 && txtPer.Text.Contains("%"))
            {
                txtPer.Text = txtPer.Text.Substring(0, txtPer.Text.Length - 1);
                return true;
            }

            return true;
        }
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
            dtEffectiveDate.Text = string.Empty;
            txtPer.Text = string.Empty;

        }
        public frmTax()
        {
            taxBLL = new TaxBLL(dbHelper);
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            var aa = dataGridView1.CurrentCell.RowIndex;
            taxID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 5 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                txtName.Text = dataGridView1.Rows[aa].Cells[1].Value.ToString();
                txtPer.Text = dataGridView1.Rows[aa].Cells[2].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[aa].Cells[3].Value.ToString();
                dtEffectiveDate.Text = dataGridView1.Rows[aa].Cells[4].Value.ToString();
            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 6 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                taxID = Convert.ToInt32(dataGridView1.Rows[aa].Cells[0].Value);
                bool check = taxBLL.DeleteTax(taxID, UserId);
                if (check == true)
                    MessageBox.Show("Selected Tax Deleted Successfully.");
                else
                    MessageBox.Show("Selected tax cannot be deleted due to mapping with other masters.");
                taxID = 0;
            }
            FillGrid();
        }       
        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = taxBLL.GetAllTax(null);
            GridBind(dt);
        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void frmTax_Load(object sender, EventArgs e)
        {
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 66;
			pictureBox1.Width = 84;

			FillGrid();
            dtEffectiveDate.Format = DateTimePickerFormat.Custom;
          
           
            dtEffectiveDate.CustomFormat = ConfigurationManager.AppSettings["DateFormat"];
          
        }

        private void lblTaxName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEffectiveFrom_Click(object sender, EventArgs e)
        {

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
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;

            }

        }
    }
}
