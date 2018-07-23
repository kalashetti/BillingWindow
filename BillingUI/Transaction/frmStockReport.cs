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
using System.Collections;
using System.Configuration;

namespace AC.Billing.UI.Transaction
{
    public partial class frmStockReport : BaseClass
    {

        #region [Member Declaration]

        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height

        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;

        private bool ReadStock;

        // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;
        private string InvImage;

        // for Report:

        string companyName = ConfigurationManager.AppSettings["Company"].ToString();
        string address1 = ConfigurationManager.AppSettings["Address1"].ToString();
        string address2 = ConfigurationManager.AppSettings["Address2"].ToString();
        string destination = ConfigurationManager.AppSettings["Destination"].ToString();
        string state = ConfigurationManager.AppSettings["State"].ToString();
        string country = ConfigurationManager.AppSettings["Country"].ToString();
        string phone = ConfigurationManager.AppSettings["Phone"].ToString();
        string mobile = ConfigurationManager.AppSettings["Mobile"].ToString();
        string email = ConfigurationManager.AppSettings["Email"].ToString();
        string GSTIN = ConfigurationManager.AppSettings["GSTIN"].ToString();
        string panNumber = ConfigurationManager.AppSettings["PAN"].ToString();
        string sGSTFlag = ConfigurationManager.AppSettings["WithoutGSTPrintFlag"].ToString();
        string sCompanyPAN = ConfigurationManager.AppSettings["CompanyPANNumber"].ToString();
        string sSeller = ConfigurationManager.AppSettings["SellerNameFooter"].ToString();

        // Font and Color:------------------
        // Title Font
        private Font InvTitleFont = new Font("Arial", 24, FontStyle.Regular);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);



        #endregion

        StockBLL stockBLL;

        public frmStockReport()
        {
            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // The Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);

            stockBLL = new StockBLL(dbHelper);
          //  inventoryBLL = new InventoryBLL(dbHelper);
          //  productBLL = new ProductBLL(dbHelper);
            InitializeComponent();
           
        }

      
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         

          

            ReadStock = true;

        }

        private void ReadInvoiceHead()
        {
            //Titles and Image of invoice:
            InvTitle = "Company Name";
            InvSubTitle1 = "Address 1";
            InvSubTitle2 = "Address 2";
            InvSubTitle3 = "Phone 2233445566";
            InvImage = Application.StartupPath + @"\Images\" + "InvPic.jpg";
        }
       
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width = 70;
			LoadDropdowns();
        }

        public void LoadDropdowns()
        {
            DataTable products = stockBLL.GetAllProducts();

            DataRow emptyRow = products.NewRow();
            emptyRow["ProductId"] = 0;
            emptyRow["ProductName"] = "";
            products.Rows.Add(emptyRow);


            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";

            comboBox1.SelectedValue = 0;

            DataTable make = stockBLL.GetAllMake();

            DataRow emptyRow2 = make.NewRow();

            emptyRow2["make"] = "";
            make.Rows.Add(emptyRow2);
            comboBox2.DataSource = make;
            comboBox2.ValueMember = "make";
            comboBox2.DisplayMember = "make";
            comboBox2.SelectedValue = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable stockReport = stockBLL.GetStockReport(Convert.ToDateTime(dateTimePicker1.Text.Trim()),Convert.ToDateTime(dateTimePicker2.Text.Trim()),Convert.ToInt32(comboBox1.SelectedValue),Convert.ToString(comboBox2.SelectedValue));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = stockReport.DefaultView;
            this.dataGridView1.AllowUserToAddRows = false;
           // dataGridView1.Columns[3].ReadOnly = true;
        }
        WebBrowser wb;
        private string CustomerName;
        private string Remarks1;
        private string BillingAddress;
        private string ShipingAddress;
        private string InvoiceNo1;
        private string MobileNo;
        private string InvoicePrintDate;
        private string FillDataGridForPrint()
        {
            CustomerName = string.Empty;
            InvoiceNo1 = string.Empty;
            MobileNo = string.Empty;
            InvoicePrintDate = string.Empty;
            BillingAddress = string.Empty;
            ShipingAddress = string.Empty;
            Remarks1 = string.Empty;
            DataTable dTable = new DataTable();
            dTable = stockBLL.GetStockReport(Convert.ToDateTime(dateTimePicker1.Text.Trim()), Convert.ToDateTime(dateTimePicker2.Text.Trim()), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToString(comboBox2.SelectedValue));
            PrintGrid.DataSource = dTable;
            PrintGrid.AutoGenerateColumns = false;           
            string Html = GenerateHtml((DataTable)PrintGrid.DataSource, CustomerName, InvoiceNo1, MobileNo, InvoicePrintDate, BillingAddress, ShipingAddress, Remarks1);
            return Html;

        }
        public string GenerateHtml(DataTable dt, string CustomerName, string InvoiceNo, string MobileNo, string InvoicePrintDate, string BillingAddress, string ShipingAddress, string Remarks1)
        {
            StringBuilder html = new StringBuilder();
            // Create string constants
            //string FormName = "form1";
            html.Append("<html  xmlns=\"http://www.w3.org/1999/xhtml\">");
            html.Append("<body style=\"font-family:'Arial'\">");
            html.Append("<head>");
            html.Append("<meta http-equiv=\"Content - Type\" content=\"text/html;charset = utf-8\" />");
            html.Append("<title>Stock Report</title>");



            html.Append("<style type=\"text/css\">");
            html.Append(Environment.NewLine);
            //html.Append("* { font-family: arial; }");
            //html.Append(Environment.NewLine);
            html.Append(".auto-style3 { border:0.25px solid black;width:500px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style5 { border:0.25px solid black;width:25%;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style6 { border:0.25px solid black;width:25%;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style7 { border:0.25px solid black;width:25%;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style9 { border:0.25px solid black;width:21px;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style11 { border:0.25px solid black;width:12px;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style13 { border:0.25px solid black;width:362px;height:12px;text-align:left;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style14 { border:0.25px solid black;width:362px;height:12px;text-align:left;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style15 { border:0.25px solid black;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style16 { border:0.25px solid black;width:55px;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style17 { border:0.25px solid black;height:12px;text-align:center;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style18 { border:0.25px solid black;width:55px;height:12px;text-align:center;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style19 { border:0.25px solid black;width:40px;height:12px;text-align:center;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style20 { border:0.25px solid black;width:95px;height:12px;text-align:center;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style21 { border:0.25px solid black;width:95px;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style22 { border:0.25px solid black;width:44px;height:18px;text-align:center;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            html.Append(".auto-style23 { border:0.25px solid black;width:44px;height:12px;word-wrap:break-word; }");
            html.Append(Environment.NewLine);
            //html.Append(".table td { text-align:right }");
            //html.Append(Environment.NewLine);

            html.Append("</style>");
            //style sheet
            html.Append("</head>");

            html.Append("<table style =");
            html.Append("\"width:100%;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");
            html.Append(">");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append("<td class=\"auto-style5\"><strong>Stock Report</strong></td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append("<strong>" + companyName.ToUpper() + "</strong>");  //CustomerName SUNRISE MARKETING AGENTS
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append(address1);  //CustomerName  "Laxmi - Govind"
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append(address2);  //BillingAddress  "Halady Road"
            html.Append("</td>");
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");  //Mode / Terms of payment
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append(address2);  //Koteshwara
            html.Append("</td>");

            html.Append("<td class=\"auto-style5\"><strong>&nbsp;</strong></td>");  // 0
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">GSTIN: <strong>");
            html.Append(GSTIN);
            html.Append("</strong></td>"); //29AAA65654654656AG
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");  //Other References
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">Email: <a href = \"mailto:" + email + "\">" + email + "</a></td>"); //smagents99@gmail.com
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");
            html.Append("</tr>");
            html.Append("</table>");

            //Separator
            //html.Append("<hr width=\"100%\" >");

            //Buyer rows
            html.Append("<table style =");
            html.Append("\"width: 100 %;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");
            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style3\" colspan=\"2\"><strong>Buyer</strong></td>");
            //html.Append("<td class=\"auto-style5\">Buyers Order No.</td>");
            //html.Append("<td class=\"auto-style5\">Dated</td>");
            //html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style6\" colspan=\"2\">");
            html.Append("<strong>" + CustomerName + "</strong></td>");
            html.Append("<td class=\"auto-style7\">" + BillingAddress + "</td>");
            html.Append("<td class=\"auto-style7\"></td>");
            html.Append("</tr>");
            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style6\" colspan=\"2\">");
            //html.Append(BillingAddress + "</td>");
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            //html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style6\">State Name:&nbsp; </td>");
            html.Append("<td  class=\"auto-style6\">Karnataka code:29</td>");
            html.Append("<td class=\"auto-style6\">GSTIN/UIN No:</td>");
            html.Append("<td class=\"auto-style6\">" + GSTIN + "</td>");  //29AAAFFF
            html.Append("</tr>");
            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style6\">GSTIN/UIN No:</td>");
            //html.Append("<td class=\"auto-style6\">" + GSTIN + "</td>");  //29AAAFFF
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style7\">" + destination + "</td>");  //Kumta
            //html.Append("</tr>");
            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style6\">PAN/IT No:</td>");
            //html.Append("<td class=\"auto-style6\">" + panNumber + "</td>");  //AUR76767K
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");  //Bill of Landing / RR No:
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");  //Motor Vehicle No:
            //html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style6\">Place of Supply:</td>");
            html.Append("<td class=\"auto-style6\">" + state + "</td>");  //Karnataka
            html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            html.Append("</tr>");
            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");  //Terms of Delivery:
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            //html.Append("</tr>");

            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style7\"><strong>&nbsp;</strong></td>");  //F.O.R Destination
            //html.Append("<td class=\"auto-style7\">&nbsp;</td>");
            //html.Append("</tr>");
            //html.Append("<tr>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("<td class=\"auto-style6\">&nbsp;</td>");
            //html.Append("</tr>");

            html.Append("</table>");

            html.Append("<table style =");
            html.Append("\"width: 100 %;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">ProductName </td>");
            html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">Make</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Quantity </td>");
            //html.Append("<td class=\"auto-style18\">");  //GST
            //html.Append("<br />");
            //html.Append("</td>"); //Rate 
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">SizeName </td>");
            //html.Append("<td class=\"auto - style22\"></td>");  //per
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">RatePerUnit</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">TaxName</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Tax</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">TaxAmount</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Discount</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">DiscountAmount</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Total</td>");
            html.Append("</tr>");
            // Add Looping TRs
            int counter = 1;
            //double Total = 0;

            foreach (DataRow dr in dt.Rows)
            {


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["ProductName"].ToString());
                html.Append("</td>");

                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["Make"].ToString());
                html.Append("</td>");


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["Quantity"].ToString());
                html.Append("</td>");


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["SizeName"].ToString());
                html.Append("</td>");



                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["RatePerUnit"].ToString());
                html.Append("</td>");


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["TaxName"].ToString());
                html.Append("</td>");





                html.Append("<td class=\"auto-style13\" style=\"text-align:right;\">");
                html.Append(dr["TaxAmount"].ToString());
                html.Append("</td>");

                html.Append("<td class=\"auto-style13\" style=\"text-align:right;\">");
                html.Append(dr["Tax"].ToString());
                html.Append("</td>");

                
                 html.Append("<td class=\"auto-style13\" style=\"text-align:right;\">");
                html.Append(dr["Discount"].ToString());
                html.Append("</td>");

                html.Append("<td class=\"auto-style13\" style=\"text-align:right;\">");
                html.Append(dr["DiscountAmount"].ToString());
                html.Append("</td>");


                html.Append("<td class=\"auto-style13\" style=\"text-align:right;\">");
                html.Append(dr["TotalAmount"].ToString());
                html.Append("</td>");
                html.Append("</tr>");

                counter++;
            }
            //html.Append("<tr>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>&nbsp;</td>");
            //html.Append("<td border: 1px solid black;>");
            //html.Append(Total.ToString());
            //html.Append("</td>");
            //html.Append("</tr>");

            html.Append("</table>");

            //table for footer of invoice
            html.Append("<table style =");
            html.Append("\"width: 100 %;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");

            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            if ((sGSTFlag == "1"))
            {
                html.Append("Composition dealer under GST");  //CustomerName
            }
            else
            {
                html.Append(" ");
            }
            html.Append("</td>");
            //html.Append("<td class=\"auto-style5\">&nbsp;</td>");
            html.Append("<td class=\"auto-style3\" >");
            html.Append("For " + companyName.ToUpper());  //CustomerName
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" >");
            //html.Append("We declare that this invoice shows the actual price of the goods described and that all particulars are true and correct");  //CustomerName
            //html.Append("Composition dealer under GST");  
            html.Append("</td>");
            html.Append("<td class=\"auto-style3\" >&nbsp;</td>");
            //html.Append("<td class=\"auto-style3\">&nbsp;</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\">&nbsp;");
            //html.Append("Company's PAN  :");  //CustomerName
            html.Append("</td>");
            //html.Append("<td class=\"auto-style5\">");
            //////AAUPFS896E
            ////html.Append(sCompanyPAN);
            //html.Append("&nbsp;</td>");
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");
            html.Append("<td class=\"auto-style3\">");
            html.Append("Signature");  //CustomerName
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("</table>");
            //html.Append("</form>");
            html.Append("</body>");
            html.Append("</html>");

            return html.ToString();
        }
        void Print(string str)
        {
            //var htmlLoadOptions = LoadOptions.None;
            //using (var htmlStream = new MemoryStream(htmlLoadOptions.Encoding.GetBytes(str)))
            //DocumentModel.Load(htmlStream, htmlLoadOptions).Print();
            wb = new WebBrowser();

            wb.DocumentText = str;


            wb.DocumentCompleted += webBrowser_DocumentCompleted;
        }
        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;          
            if (wb.ReadyState.Equals(WebBrowserReadyState.Complete))
                wb.ShowPrintDialog();
            //else
            //    wb.ShowPrintPreviewDialog();
            //((WebBrowser)sender).ShowPrintPreviewDialog();
            //((WebBrowser)sender).Print();

          
           
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;
            wb.Parent = lblPrint;          
            if (wb.ReadyState.Equals(WebBrowserReadyState.Complete))
                wb.ShowPrintPreviewDialog();

          
            
        }

        void PrintPreview(string str)
        {

            //var htmlLoadOptions = LoadOptions.None;
            //using (var htmlStream = new MemoryStream(htmlLoadOptions.Encoding.GetBytes(str)))
            //DocumentModel.Load(htmlStream, htmlLoadOptions).Print();
            wb = new WebBrowser();         
            wb.DocumentText = str;
       

            //wb.ShowPrintDialog();

            // wb.Print();

            wb.DocumentCompleted += webBrowser1_DocumentCompleted;


        }
        private void PrintReport()
        {
            try
            {
                prnDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string html;
            //if (!ReadInvoice)

            html = FillDataGridForPrint();

            Print(html);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string html;
            html = FillDataGridForPrint();

            PrintPreview(html);
        }

        private void DisplayInvoice()
        {
            prnPreview.Document = this.prnDocument;

            try
            {
                prnPreview.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
