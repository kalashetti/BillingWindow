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
    public partial class frmDeleveryNoteReport : BaseClass
    {
        #region Member Variables

        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        #endregion

        #region Member Variables
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;
        // private System.ComponentModel.Container component = null;

        // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;
        private string InvImage;

        // for Report:
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;
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
        #region [Variable Declaration]
        DeliveryNoteBLL deliveryNoteBLL;
        ProductBLL productBLL;      
        #endregion [Variable Declaration]
        public frmDeleveryNoteReport()
        {
            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // The Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
            deliveryNoteBLL = new DeliveryNoteBLL(dbHelper);
            productBLL = new ProductBLL(dbHelper);
            InitializeComponent();
        }
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;

            //if (!ReadInvoice)
            //    FillDataGridForPrint();

            SetInvoiceHead(e.Graphics); // Draw Invoice Head
                                        //SetOrderData(e.Graphics); // Draw Order Data
            SetInvoiceData(e.Graphics, e); // Draw Invoice Data

          

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
            html.Append("<title>DeliveryNote Report</title>");



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
            html.Append("<td class=\"auto-style5\"><strong>DeliveryNote Report</strong></td>");
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
            html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">Invoice</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Customer</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">DeliveryMode</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Date</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Tax</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Discount</td>");
            html.Append("<td class=\"auto-style17\" style=\"vertical-align:middle;\">Total</td>");
            html.Append("</tr>");
            // Add Looping TRs
            int counter = 1;
            //double Total = 0;

            foreach (DataRow dr in dt.Rows)
            {


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["InvoiceNo"].ToString());
                html.Append("</td>");

                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["CustomerName"].ToString());
                html.Append("</td>");


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");
                html.Append(dr["DeliveryMode"].ToString());
                html.Append("</td>");


                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle;\">");              
                html.Append(Convert.ToDateTime(dr["DeliveryDate"].ToString()).ToString("MM-dd-yy"));
                html.Append("</td>");

                html.Append("<td class=\"auto-style13\" style=\"text-align:right;\">");
                html.Append(dr["TaxAmount"].ToString());
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
            DataTable dt = new DataTable();
            dt = deliveryNoteBLL.GetDeliveryNoteReport(Convert.ToDateTime(txtStartDate.Text.Trim()), Convert.ToDateTime(txtEndDate.Text.Trim()));
            PrintGrid.DataSource = dt;
            PrintGrid.AutoGenerateColumns = false;
            // DataTable dt = (DataTable)PrintGrid.DataSource
            string Html = GenerateHtml((DataTable)PrintGrid.DataSource, CustomerName, InvoiceNo1, MobileNo, InvoicePrintDate, BillingAddress, ShipingAddress, Remarks1);

            return Html;

        }

        void Print(string str)
        {
            //var htmlLoadOptions = LoadOptions.None;
            //using (var htmlStream = new MemoryStream(htmlLoadOptions.Encoding.GetBytes(str)))
            //DocumentModel.Load(htmlStream, htmlLoadOptions).Print();
            wb = new WebBrowser();
            wb.DocumentText = str;

            //wb.ShowPrintDialog();

            // wb.Print();

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

            //((WebBrowser)sender).Dispose();
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;
            wb.Parent = lblPrint;     
            if (wb.ReadyState.Equals(WebBrowserReadyState.Complete))
                wb.ShowPrintPreviewDialog();
            //else
            //    wb.ShowPrintPreviewDialog();
            //((WebBrowser)sender).ShowPrintPreviewDialog();
            //((WebBrowser)sender).Print();

            //((WebBrowser)sender).Dispose();
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
        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }

                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            SetInvoiceHead(g);
                            string FieldValue = "";
                            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
                            // Set Company Name:
                            CurrentX = leftMargin;
                            CurrentY = CurrentY + 8;
                            FieldValue = "Customer Name: " + "dfdsfsf";
                            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
                            //// Set City:
                            //CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
                            //FieldValue = "City: " + CustomerCity;
                            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
                            //// Set Salesperson:
                            //CurrentX = leftMargin;
                            //CurrentY = CurrentY + InvoiceFontHeight;
                            //FieldValue = "Salesperson: " + SellerName;
                            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
                            //// Set Order ID:
                            //CurrentX = leftMargin;
                            //CurrentY = CurrentY + InvoiceFontHeight;
                            //FieldValue = "Order ID: " + SaleID;
                            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
                            //// Set Order Date:
                            //CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
                            //FieldValue = "Order Date: " + SaleDate;
                            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

                            // Draw line:
                            CurrentY = CurrentY + InvoiceFontHeight + 8;
                            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
                            iTopMargin = e.MarginBounds.Top + 160;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayDialog()
        {
            try
            {
                prnDialog.Document = this.prnDocument;
                DialogResult ButtonPressed = prnDialog.ShowDialog();
                // If user Click 'OK', Print Invoice
                if (ButtonPressed == DialogResult.OK)
                    prnDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
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
        private void ReadInvoiceHead()
        {
            //Titles and Image of invoice:
            InvTitle = "Company Name";
            InvSubTitle1 = "Address 1";
            InvSubTitle2 = "Address 2";
            InvSubTitle3 = "Phone 2233445566";
            InvImage = Application.StartupPath + @"\Images\" + "InvPic.jpg";
        }
        private void SetInvoiceHead(Graphics g)
        {
            ReadInvoiceHead();

            CurrentY = topMargin;
            CurrentX = leftMargin;
            int ImageHeight = 0;

            // Draw Invoice image:
            if (System.IO.File.Exists(InvImage))
            {
                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
                ImageHeight = oInvImage.Height; // Get Image Height
                g.DrawImage(oInvImage, xImage, CurrentY);
            }

            InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;

            // Draw Invoice Head:
            if (InvTitle != "")
            {
                CurrentY = CurrentY + ImageHeight;
                g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
            }
            if (InvSubTitle1 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
            }
            if (InvSubTitle2 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
            }
            if (InvSubTitle3 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
            }

            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStartDate.Text.Trim()) && !string.IsNullOrWhiteSpace(txtEndDate.Text.Trim()))
            {
                FillGrid();


            }

        }
        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = deliveryNoteBLL.GetDeliveryNoteReport(Convert.ToDateTime(txtStartDate.Text.Trim()), Convert.ToDateTime(txtEndDate.Text.Trim()));
            GridBind(dt);
        }

        private void GridBind(DataTable dt)
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[3].ReadOnly = true;

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            string html;
            html = FillDataGridForPrint();

            PrintPreview(html);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string html;
            //if (!ReadInvoice)

            html = FillDataGridForPrint();

            Print(html);
        }

        private void frmDeleveryNoteReport_Load(object sender, EventArgs e)
        {
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width = 70;
			txtStartDate.Format = DateTimePickerFormat.Custom;


            txtStartDate.CustomFormat = ConfigurationManager.AppSettings["DateFormat"];
            txtEndDate.Format = DateTimePickerFormat.Custom;


            txtEndDate.CustomFormat = ConfigurationManager.AppSettings["DateFormat"];
        }
    }
}
