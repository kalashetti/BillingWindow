using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AC.Billing.Business;
using AC.Billing.DataAccess;
using AC.Billing.UI;
using System.Configuration;

namespace BillingUI
{
    public partial class Form1 :BaseClass
    { 
        
        #region [Variable Declaration]       
        UserBLL userBLL;

       

        #endregion [Variable Declaration]  
           
        public Form1()
        {
            userBLL = new UserBLL(dbHelper);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width =70;
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                DataTable dtUserDetails = userBLL.GetUserDetails(txtLoginId.Text.Trim(), txtPassword.Text.Trim());

                if (dtUserDetails != null)
                {
                    if (dtUserDetails.Rows.Count > 0)
                    {
                        USERID = Convert.ToInt32(dtUserDetails.Rows[0]["Id"].ToString());
                        MDIParent obj = new MDIParent();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct  login id  and password.");
                        txtLoginId.Focus();                      

                    }
                }               
            }           
        }

        private  bool Validation()
        {
            
            if (string.IsNullOrEmpty(txtLoginId.Text.Trim()))
            {
                MessageBox.Show("Please enter Login Id.");
                txtLoginId.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Please enter Password.");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLoginId.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword frm = new ForgotPassword();
            frm.Show();
        }

		private void lblLogin_Click(object sender, EventArgs e)
		{

		}
	}
}
