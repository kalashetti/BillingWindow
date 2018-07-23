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
    public partial class frmSize : BaseClass
    {
        #region [Variable Declaration]       
        SizeBLL sizeBLL;
        ProductBLL productBLL;
        int sizeId, UserId = 1;

        #endregion [Variable Declaration]  
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbUnit.SelectedValue.ToString() != "0" && txtName.Text.Trim() != string.Empty)
            {
              if( sizeBLL.SizeSave(sizeId, txtName.Text.Trim(), txtDesc.Text.Trim(), UserId, Convert.ToInt32(cbUnit.SelectedValue)))
                {
                    sizeId = 0;
                    ClearFields();
                    FillGrid();
                }
              else
                {
                    MessageBox.Show("Selected size cannot be updated due to mapping with other masters and transaction.");
                }
              
            }
            else
            {
                MessageBox.Show("Please enter required values.");
            }
        }
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
            cbUnit.SelectedValue = 0;
            sizeId = 0;

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

        public frmSize()
        {
            sizeBLL = new SizeBLL(dbHelper);
            productBLL = new ProductBLL(dbHelper);
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }
        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = sizeBLL.GetAllSize(null, null);
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
			pictureBox1.Height = 66;
			pictureBox1.Width = 84;

			Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
            GetAllUnit();
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
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 5 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {
                txtName.Text = dataGridView1.Rows[aa].Cells[2].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[aa].Cells[4].Value.ToString();
                cbUnit.SelectedValue = dataGridView1.Rows[aa].Cells[3].Value.ToString();

            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 6 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dataGridView1.Rows[aa].Cells[0].Value.ToString()))))
            {

                bool check = sizeBLL.SizeDelete(sizeId, UserId);
                if (check == true)
                    MessageBox.Show("Selected size deleted Successfully.");
                else
                    MessageBox.Show("Selected size cannot be deleted due to mapping with other masters.");
                sizeId = 0;
            }
            FillGrid();
        }
    }
}
