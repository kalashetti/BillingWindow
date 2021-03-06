﻿using System;
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
using System.Collections;

namespace AC.Billing.UI.Transaction
{
    public partial class Inventory : BaseClass
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

        WebBrowser wb;

        //read config values
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

        //Grid Column
        public const int ConstIsDelete = 0;
        public const int ConstInvoiceItemID = 1;
        public const int ConstInvoiceID = 2;
        public const int ConstProductID = 3;
        public const int ConstTaxID = 4;
        public const int ConstSizeID = 5;
        public const int ConstProduct = 6;
        public const int ConstHAN = 7;
        public const int ConstMake = 8;
        public const int ConstQuantity = 9;
        public const int ConstUnit = 10;
        public const int ConstRate = 11;
        public const int ConstSize = 12;
        public const int ConstTax = 13;
        public const int ConstTaxAmount = 14;
        public const int ConstDiscount = 15;
        public const int ConstDiscountAmount = 16;
        public const int ConstTotal = 17;
        public const int ConstRemark = 18;
        public const int ConstUnitID = 19;
        //end
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
        private string InvSubTitle4;
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
        private string CustomerName;
		private string CustomerGSTIN;
		// private string Remarks;
		private string BillingAddress;
        private string ShipingAddress;
        private string InvoiceNo;
        private string MobileNo;


        private string InvoicePrintDate;

        private decimal InvoiceTotal;
        private bool ReadInvoice;


        // Font and Color:------------------
        // Title Font
        private Font InvTitleFont = new Font("Arial", 16, FontStyle.Regular);
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

        InventoryBLL inventoryBLL;
        SizeBLL sizeBLL;
        int  UserId = 1;
        int InventoryID;
        ProductBLL productBLL;       
        DataTable dtInventoryItem;

        #endregion [Variable Declaration]  

        #region [Events] 

        public Inventory()
        {
            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // The Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
            inventoryBLL = new InventoryBLL(dbHelper);
            productBLL = new ProductBLL(dbHelper);
            sizeBLL = new SizeBLL(dbHelper);
            InitializeComponent();
            gvInventory.CellContentClick += gvInventory_CellContentClick;
            FillCombo();
            FillGrid();
            this.gvInventory.AllowUserToAddRows = false;

        }
        private string FillDataGridForPrint()
        {
            DataTable dtInvoice = new DataTable();
            string Remarks1 = String.Empty;
            dtInvoice = inventoryBLL.GetAllInventory(InventoryID);
            if (dtInvoice.Rows.Count > 0)
            {

                CustomerName = Convert.ToString(dtInvoice.Rows[0]["CompanyName"]);
                BillingAddress = Convert.ToString(dtInvoice.Rows[0]["BillingAddress"]);
                ShipingAddress = Convert.ToString(dtInvoice.Rows[0]["ShippingAddress"]);
                MobileNo = Convert.ToString(dtInvoice.Rows[0]["ContactNumber"]);
                InvoicePrintDate = Convert.ToString(dtInvoice.Rows[0]["InventoryDate"]);
                InvoiceNo = Convert.ToString(dtInvoice.Rows[0]["InvoiceNo"]);
				if (dtInvoice.Rows[0]["GSTIN"] != null)
				{
					CustomerGSTIN = Convert.ToString(dtInvoice.Rows[0]["GSTIN"]);
				}
				else
				{
					CustomerGSTIN = string.Empty;
				}


			}

            DataTable dTable = new DataTable();
            dTable = inventoryBLL.GetAllInventoryItemReport(InventoryID, 0);

            PrintGrid.DataSource = dTable;
            PrintGrid.AutoGenerateColumns = false;
			// DataTable dt = (DataTable)PrintGrid.DataSource
			//string Html = GenerateHtml((DataTable)PrintGrid.DataSource, CustomerName, InvoiceNo, MobileNo, InvoicePrintDate, BillingAddress, ShipingAddress, Remarks1, CustomerGSTIN);
			string Html = GenerateHtmlNew((DataTable)PrintGrid.DataSource, CustomerName, InvoiceNo, MobileNo, InvoicePrintDate, BillingAddress, ShipingAddress, Remarks1, CustomerGSTIN);


			return Html;
        }

		public string GenerateHtmlNew(DataTable dt, string CustomerName, string InvoiceNo, string MobileNo, string InvoicePrintDate, string BillingAddress, string ShipingAddress, string Remarks1, string CustomerGSTIN)
		{
			StringBuilder html = new StringBuilder();
			// Create string constants
			//string FormName = "form1";
			html.Append("<html  xmlns=\"http://www.w3.org/1999/xhtml\">");
			html.Append("<body style=\"font-family:'Arial'\">");
			html.Append("<head>");
			html.Append("<meta http-equiv=\"Content - Type\" content=\"text/html;charset = utf-8\" />");
			html.Append("<title>Invoice</title>");




			html.Append("<style type=\"text/css\">");
			html.Append(Environment.NewLine);
			//html.Append("* { font-family: arial; }");
			//html.Append(Environment.NewLine);//style=\"width:50px;border-bottom: 1px solid ;\"
			html.Append(".invoice { border:2px;border-right: 1px solid ;border-left: 1px solid; font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif;border-collapse: collapse;  font-size:10px}");
			html.Append(".invoiceTd { border-bottom: 1px solid; font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif;border-collapse: collapse;  font-size:11px}");
			html.Append(Environment.NewLine);
			html.Append(".auto-style3 { border:0.25px solid black;width:500px;word-wrap:break-word;font-size:14px }");
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
			html.Append(".auto-style22 {  1em;border:0.25px solid black;width:44px;height:18px;text-align:center;word-wrap:break-word; }");
			html.Append(Environment.NewLine);
			html.Append(".auto-style23 { border:0.25px solid black;width:44px;height:12px;word-wrap:break-word; }");
			html.Append(Environment.NewLine);
			//html.Append(".table td { text-align:right }");
			//html.Append(Environment.NewLine);

			html.Append("</style>");
			//style sheet
			html.Append("</head>");

			html.Append("<table style =");
			html.Append("\"width:100%;border-left:1px solid;border-top:2px solid;border-bottom:1px solid;border-right:1px solid;\"");
			html.Append(">");
			html.Append("<tr>");
			//html.Append("<td class=\"auto-style3\" style=\"border-bottom: 1px solid ;\" colspan=\"2\">");			
			html.Append("<td class=\"auto-style5\" style=\"text-align: center ;border-bottom: 1px solid \" colspan=\"3\"><strong>INVENTORY</strong></td>");
			html.Append("</tr>");
			html.Append("<tr>");
			html.Append("<td class=\"invoiceTd\" style=\" width:36%; border-bottom: 1px solid ;\" >");
			html.Append("<strong>" + companyName.ToUpper() + "</strong>");
			html.Append("</td>");
			html.Append("<td class=\"invoiceTd\" style=\"width:32%; border-bottom: 1px solid ;\">Invoice No.: " + InvoiceNo + "</td>");
			html.Append("<td class=\"invoiceTd\" style=\" width:32%; border-bottom: 1px solid ;\">Date : " + Convert.ToDateTime(InvoicePrintDate).ToLongDateString() + "</td>");
			html.Append("</tr>");
			html.Append("<tr>");
			html.Append("<td class=\"invoiceTd\" style=\"width:36%;border-bottom: 0px solid ;\" >");
			html.Append(address1);
			html.Append("</td>");
			html.Append("<td class=\"invoiceTd\" style=\"width:32%;border-bottom: 1px solid ;\">GSTIN:" + GSTIN + "</td>");

			html.Append("<td class=\"invoiceTd\" style=\"width:32%;border-bottom: 1px solid ;\">Email: <a href = \"mailto:" + email + "\">" + email + "</a></td>");
			html.Append("</tr>");
			html.Append("<tr>");
			html.Append("<td class=\"invoiceTd\" style=\"width:36%;border-bottom: 0px solid ;\" >");
			html.Append(address2);
			html.Append("</td>");
			//html.Append("<td class=\"invoiceTd\" style=\"border-bottom: 1px solid ;\">Remarks :</td>");
			html.Append("<td class=\"invoiceTd\" colspan=\"2\" style=\"width:64%;border-bottom: 1px solid ;\">Remarks : " + Remarks1 + "</td>");
			html.Append("</tr>");


			html.Append("</table>");

			//Separator
			//html.Append("<hr width=\"100%\" >");

			//Buyer rows
			html.Append("<table style =");
			html.Append("\"width: 100 %;border-left:1px solid;border-top: 1px solid;border-bottom:1px solid;border-right:1px solid;\"");

			html.Append("<tr>");
			html.Append("<td class=\"invoiceTd\" style=\" width:36%; \" colspan=\"2\">");
			html.Append("<strong>" + CustomerName + "</strong></td>");
			html.Append("<td class=\"invoiceTd\" style=\" width:32%; \" >Billing Address :" + BillingAddress + "</td>");
			html.Append("<td class=\"invoiceTd\" style=\" width:32%; \" >Shipping Address :" + ShipingAddress + "</td>");
			html.Append("</tr>");

			html.Append("<tr>");
			html.Append("<td class=\"invoiceTd\">State Name : " + state + " </td>");
			html.Append("<td  class=\"invoiceTd\"></td>");
			html.Append("<td class=\"invoiceTd\">GSTIN/UIN No.: " + CustomerGSTIN + "</td>");
			html.Append("<td class=\"invoiceTd\"></td>");  //29AAAFFF
			html.Append("</tr>");

			html.Append("<tr>");
			html.Append("<td class=\"invoiceTd\" >Place of Supply : " + state + "</td>");
			html.Append("<td class=\"invoiceTd\"></td>");  //Karnataka
			html.Append("<td class=\"invoiceTd\">Mobile No. : " + MobileNo + "</td>");
			html.Append("<td class=\"invoiceTd\"></td>");
			html.Append("</tr>");


			html.Append("</table>");

			//if GST is not needed to be shown
			if ((sGSTFlag == "1"))  //   reading from config file (rbWithoutGST.Checked == true) || 
			{
				html.Append("<table style =");
				//html.Append("\"width: 100 %;border-collapse: collapse;border-left:1px solid;border-top:1px solid;border-bottom:1px solid;border-right:1px solid;\"");
				html.Append("\" border:5px; border-collapse: collapse;border-left:1px solid;border-top:1px solid;border-bottom:1px solid;border-right:1px solid;\"");
				html.Append("<tr>");
				html.Append("<td class=\"invoice\" style=\"width:50px;border-bottom: 1px solid ;\" >Sl.No.</td>");
				html.Append("<td class=\"invoice\" style=\"width:350px;vertical-align:middle;border-bottom: 1px solid\" >Description of Goods & Services</td>");
				html.Append("<td class=\"invoice\" style=\"width:100px;border-bottom: 1px solid\">HSN/SAC</td>");

				html.Append("<td class=\"invoice\" style=\"text-align:right;width:80px;border-bottom: 1px solid\">Quantity</td>");
				html.Append("<td class=\"invoice\" style=\"text-align:right;width:80px;border-bottom: 1px solid\">Rate</td>");
				//html.Append("<td class=\"invoice\"></td>");  //per
				html.Append("<td class=\"invoice\" style=\"text-align:right;width:90px;border-bottom: 1px solid\">Amount</td>");
				html.Append("</tr>");


			}
			else
			{
				html.Append("<table style =");
				//html.Append("\"width: 100 %;border-collapse: collapse;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");
				html.Append("\" border:5px; border-collapse: collapse;border-left:1px solid;border-top: 1px solid;border-bottom:1px solid;border-right:1px solid;\"");
				html.Append("<tr >");
				html.Append("<td class=\"invoice\" style=\"width:50px;border-bottom: 1px solid\" >Sl.No.</td>");
				html.Append("<td class=\"invoice\" style=\"width:300px;border-bottom: 1px solid\" >Description of Goods & Services</td>");
				html.Append("<td class=\"invoice\" style=\"width:80px;border-bottom: 1px solid\">HSN/SAC</td>");
				html.Append("<td class=\"invoice\" style=\"width:70px; text-align:right;border-bottom: 1px solid\">Quantity</td>");
				html.Append("<td class=\"invoice\" style=\"width:70px;text-align:right;border-bottom: 1px solid\">Rate</td>");
				html.Append("<td class=\"invoice\" style=\"width:100px;text-align:right;border-bottom: 1px solid\">Unit</td>");
				//html.Append("<td class=\"invoice\">per</td>");
				html.Append("<td class=\"invoice\" style=\" width:50px; text-align:right;border-bottom: 1px solid\">GST");
				// html.Append("<br />");
				//html.Append("Rate </td>");
				//html.Append("<td class=\"auto-style18\">SGST");
				//html.Append("<br />");
				//html.Append("Rate </td>");
				html.Append("<td class=\"invoice\" style=\"width:90px;text-align:right;border-bottom: 1px solid\">Amount</td>");
				html.Append("</tr>");


			}


			// Add Looping TRs
			int counter = 1;

			if ((sGSTFlag == "1"))  // (rbWithoutGST.Checked == true) ||
			{
				foreach (DataRow dr in dt.Rows)
				{
					html.Append("<tr>");
					if (dr[0] != System.DBNull.Value & dr[0].ToString() != String.Empty)
					{
						html.Append("<td class=\"invoice\" style=\"text-align:left;\">");
						html.Append(counter.ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:left;\">");
						html.Append(dr[0].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\">");
						html.Append(dr[1].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
						html.Append(dr[2].ToString());
						html.Append("</td>");

						if (!String.IsNullOrEmpty(dr[3].ToString()) && !String.IsNullOrEmpty(dr[5].ToString()) && !String.IsNullOrEmpty(dr[6].ToString()))
						{
							double rate = Convert.ToDouble(dr[3].ToString());
							double cgstAmount = Convert.ToDouble(dr[5].ToString());
							double sgstAmount = Convert.ToDouble(dr[6].ToString());
							//double ratePlusTax = rate + cgstAmount + sgstAmount;
							double amount = Convert.ToDouble(dr[9].ToString());
							double quantity = Convert.ToDouble(dr[2].ToString());
							double ratePlusTax = Math.Truncate((amount / quantity) * 100) / 100;

							html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
							html.Append(ratePlusTax.ToString());   //dr[3].ToString()
							html.Append("</td>");
						}

						html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
						html.Append(dr[9].ToString());
						html.Append("</td>");


					}
					else
					{
						if ((dr[6].ToString().Contains("CGST") || dr[6].ToString().Contains("SGST") || dr[6].ToString().Contains("Total GST") || dr[6].ToString().Contains("Total without GST")))
						{
							//html.Append("<td border: 1px solid black;>");
							//html.Append(dr[6].ToString());
							//html.Append("</td>");

							//html.Append("<td border: 1px solid black;>");
							//html.Append(dr[7].ToString());
							//html.Append("</td>");
						}
						else if ((dr[6].ToString().Contains("Total Amount")))
						{
							html.Append("<td class=\"invoice\" style=\"border:0.25px solid black;text-align:right;\" colspan=\"5\">");
							html.Append("Total Amount");
							html.Append("</td>");

							html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
							html.Append(dr[9].ToString());
							html.Append("</td>");


						}
					}

					//html.Append("<td border: 1px solid black;>");
					//html.Append(dr[4].ToString());
					//html.Append("</td>");

					//html.Append("<td border: 1px solid black;>");
					//html.Append(dr[5].ToString());
					//html.Append("</td>");

					//if (dr[7] !=System.DBNull.Value)
					//    Total = Total + Convert.ToDouble(dr[7]);

					if (counter == dt.Rows.Count)
					{
						//For displaying Total Amount in words
						html.Append("<tr>");
						html.Append("<td class=\"invoice\" style=\"border:0.25px solid black;text-align:left; border-top: 1px solid;\" colspan=\"7\">");
						int totalAmount = Convert.ToInt32(Math.Round(Convert.ToDouble(dr[9].ToString())));
						string strWords = ConvertNumbertoWords(totalAmount);
						html.Append("Total Amount in Words: RUPEES " + strWords + " ONLY");
						html.Append("</td>");
						html.Append("</tr>");
					}

					html.Append("</tr>");

					counter++;
				}
			}
			else
			{
				string strTaxAmount = "Tax Amount in Words: ";
				foreach (DataRow dr in dt.Rows)
				{
					html.Append("<tr>");
					if (dr[0] != System.DBNull.Value & dr[0].ToString() != String.Empty)
					{
						html.Append("<td class=\"invoice\">");
						html.Append(counter.ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:left;\">");
						html.Append(dr[0].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" >");
						html.Append(dr[1].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
						html.Append(dr[2].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
						html.Append(dr[3].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
						html.Append(dr[8].ToString());
						html.Append("</td>");

						html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
						html.Append(dr[7].ToString());
						html.Append("</td>");


					}
					else
					{
						html.Append("<td class=\"invoice\" style=\"border:0.25px solid black;text-align:right;\" colspan=\"7\">");
						html.Append(dr[6].ToString());
						html.Append("</td>");
					}

					html.Append("<td class=\"invoice\" style=\"text-align:right;\">");
					html.Append(dr[9].ToString());
					html.Append("</td>");

					//if (dr[7] !=System.DBNull.Value)
					//    Total = Total + Convert.ToDouble(dr[7]);

					html.Append("</tr>");

					if (counter == dt.Rows.Count - 1)
					{
						int taxAmount = Convert.ToInt32(Math.Round(Convert.ToDouble(dr[9].ToString())));
						strTaxAmount = "Tax Amount in Words: RUPEES " + ConvertNumbertoWords(taxAmount) + " ONLY";
					}

					if (counter == dt.Rows.Count)
					{
						//For displaying Total Amount in words
						html.Append("<tr>");
						html.Append("<td class=\"invoice\" style=\"border:0.25px solid black;text-align:left; border-top: 1px solid;\" colspan=\"8\">");
						int totalAmount = Convert.ToInt32(Math.Round(Convert.ToDouble(dr[9].ToString())));
						string strWords = ConvertNumbertoWords(totalAmount);
						html.Append(strTaxAmount + "  <br/>Total Amount in Words: RUPEES " + strWords + " ONLY");
						html.Append("</td>");
						html.Append("</tr>");
					}

					counter++;
				}
			}

			html.Append("</table>");

			//table for footer of invoice
			html.Append("<table style =");
			html.Append("\"width: 100 %;border-left:1px solid;border-top:1px solid;border-bottom:2px solid;border-right:1px solid;\"");

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
			html.Append("<td class=\"invoiceTd\" >");
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

		public string GenerateHtml(DataTable dt, string CustomerName, string InvoiceNo, string MobileNo, string InvoicePrintDate, string BillingAddress, string ShipingAddress, string Remarks1,string CustomerGSTIN)
        {
            StringBuilder html = new StringBuilder();
            // Create string constants
            //string FormName = "form1";
            html.Append("<html  xmlns=\"http://www.w3.org/1999/xhtml\">");
            html.Append("<body style=\"font-family:'Arial'\">");
            html.Append("<head>");
            html.Append("<meta http-equiv=\"Content - Type\" content=\"text/html;charset = utf-8\" />");
            html.Append("<title>Inventory</title>");

            //style sheet
            //html.Append("<style type=\"text/css\">");
            //html.Append(Environment.NewLine);
            ////html.Append("* { font-family: arial; }");
            ////html.Append(Environment.NewLine);
            //html.Append(".auto-style3 { border:1px solid black;width:500px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style5 { border:1px solid black;width:25%;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style6 { border:1px solid black;width:25%;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style7 { border:1px solid black;width:25%;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style9 { border:1px solid black;width:21px;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style11 { border:1px solid black;width:12px;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style13 { border:1px solid black;width:362px;height:23px;text-align:left;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style15 { border:1px solid black;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style16 { border:1px solid black;width:55px;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style17 { border:1px solid black;height:23px;text-align:left;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style18 { border:1px solid black;width:55px;height:23px;text-align:left;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style19 { border:1px solid black;width:40px;height:23px;text-align:left;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style20 { border:1px solid black;width:95px;height:23px;text-align:left;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style21 { border:1px solid black;width:95px;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style22 { border:1px solid black;width:44px;height:23px;text-align:left;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".auto-style23 { border:1px solid black;width:44px;height:23px;word-wrap:break-word; }");
            //html.Append(Environment.NewLine);
            //html.Append(".table td { text-align:right }");
            //html.Append(Environment.NewLine);

            //html.Append("</style>");


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
            html.Append("<td class=\"auto-style5\"><strong>Inventory</strong></td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append("<strong>" + companyName.ToUpper() + "</strong>");  //CustomerName SUNRISE MARKETING AGENTS
            html.Append("</td>");
            html.Append("<td class=\"auto-style5\">Invoice No.</td>");
            html.Append("<td class=\"auto-style5\">Dated</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append(address1);  //CustomerName  "Laxmi - Govind"
            html.Append("</td>");
            html.Append("<td class=\"auto-style5\"><strong>");
            html.Append(InvoiceNo);
            html.Append("</strong></td>");
            html.Append("<td class=\"auto-style5\"><strong>");
            html.Append(InvoicePrintDate);
            html.Append("</strong></td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            html.Append(address2);  //BillingAddress  "Halady Road"
            html.Append("</td>");
            html.Append("<td class=\"auto-style5\">Remarks</td>");
            html.Append("<td class=\"auto-style5\">&nbsp;</td>");  //Mode / Terms of payment
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td class=\"auto-style3\" colspan=\"2\">");
            //html.Append(address2);  //Koteshwara
            html.Append("</td>");
            html.Append("<td class=\"auto-style5\">");
            html.Append(Remarks1);
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
            html.Append("<td class=\"auto-style6\">" + CustomerGSTIN + "</td>");  //29AAAFFF
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

            //if GST is not needed to be shown
            if ((sGSTFlag == "1"))  //   reading from config file (rbWithoutGST.Checked == true) || 
            {
                html.Append("<table style =");
                html.Append("\"width: 100 %;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");
                html.Append("<tr>");
                html.Append("<td class=\"auto-style9\">Sl.No.</td>");
                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle\">Description of Goods</td>");
                html.Append("<td class=\"auto-style18\">HSN/SAC</td>");
                //html.Append("<td class=\"auto-style18\">");  //GST
                //html.Append("<br />");
                //html.Append("</td>"); //Rate 
                html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">Quantity</td>");
                html.Append("<td class=\"auto-style20\" style=\"text-align:right;\">Rate</td>");
                //html.Append("<td class=\"auto - style22\"></td>");  //per
                html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">Amount</td>");
                html.Append("</tr>");

                //html.Append("<tr>");
                //html.Append("<td class=\"auto-style9\"></td>");
                //html.Append("<td class=\"auto-style13\" style=\"vertical - align: text - top\"></td>");
                //html.Append("<td class=\"auto-style18\"></td>");
                ////html.Append("<td class=\"auto-style18\">");  //GST
                ////html.Append("<br />");
                ////html.Append("</td>"); //Rate 
                //html.Append("<td class=\"auto - style17\"></td>");
                //html.Append("<td class=\"auto - style20\"></td>");
                ////html.Append("<td class=\"auto - style22\"></td>");  //per
                //html.Append("<td class=\"auto - style17\"></td>");
                //html.Append("</tr>");
            }
            else
            {
                html.Append("<table style =");
                html.Append("\"width: 100 %;border-left:solid;border-top:solid;border-bottom:solid;border-right:solid;\"");
                html.Append("<tr >");
                html.Append("<td class=\"auto-style9\">Sl.No.</td>");
                html.Append("<td class=\"auto-style13\" style=\"vertical-align:middle\">Description of Goods</td>");
                html.Append("<td class=\"auto-style18\">HSN/SAC</td>");
                html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">Quantity</td>");
                html.Append("<td class=\"auto-style20\" style=\"text-align:right;\">Rate</td>");
                html.Append("<td class=\"auto-style20\" style=\"text-align:right;\">Unit</td>");
                //html.Append("<td class=\"auto-style22\">per</td>");
                html.Append("<td class=\"auto-style18\" style=\"text-align:right;\">GST");
                // html.Append("<br />");
                //html.Append("Rate </td>");
                //html.Append("<td class=\"auto-style18\">SGST");
                //html.Append("<br />");
                //html.Append("Rate </td>");
                html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">Amount</td>");
                html.Append("</tr>");

                //html.Append("<tr>");
                //html.Append("<td class=\"auto-style9\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style13\" style=\"vertical-align:text-top\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style11\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style16\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style15\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style21\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style23\">&nbsp;</td>");
                //html.Append("<td class=\"auto-style15\">&nbsp;</td>");
                //html.Append("</tr>");
            }


            // Add Looping TRs
            int counter = 1;
            //double Total = 0;

            if ((sGSTFlag == "1"))  // (rbWithoutGST.Checked == true) ||
            {
                foreach (DataRow dr in dt.Rows)
                {
                    html.Append("<tr>");
                    if (dr[0] != System.DBNull.Value & dr[0].ToString() != String.Empty)
                    {
                        html.Append("<td class=\"auto-style9\" style=\"text-align:left;\">");
                        html.Append(counter.ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style13\" style=\"text-align:left;\">");
                        html.Append(dr[0].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style18\">");
                        html.Append(dr[1].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">");
                        html.Append(dr[2].ToString());
                        html.Append("</td>");

                        if (!String.IsNullOrEmpty(dr[3].ToString()) && !String.IsNullOrEmpty(dr[5].ToString()) && !String.IsNullOrEmpty(dr[6].ToString()))
                        {
                            double rate = Convert.ToDouble(dr[3].ToString());
                            double cgstAmount = Convert.ToDouble(dr[5].ToString());
                            double sgstAmount = Convert.ToDouble(dr[6].ToString());
                            //double ratePlusTax = rate + cgstAmount + sgstAmount;
                            double amount = Convert.ToDouble(dr[9].ToString());
                            double quantity = Convert.ToDouble(dr[2].ToString());
                            double ratePlusTax = Math.Truncate((amount / quantity) * 100) / 100;

                            html.Append("<td class=\"auto-style20\" style=\"text-align:right;\">");
                            html.Append(ratePlusTax.ToString());   //dr[3].ToString()
                            html.Append("</td>");
                        }

                        html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">");
                        html.Append(dr[9].ToString());
                        html.Append("</td>");
                    }
                    else
                    {
                        if ((dr[6].ToString().Contains("CGST") || dr[6].ToString().Contains("SGST") || dr[6].ToString().Contains("Total GST") || dr[6].ToString().Contains("Total without GST")))
                        {
                            //html.Append("<td border: 1px solid black;>");
                            //html.Append(dr[6].ToString());
                            //html.Append("</td>");

                            //html.Append("<td border: 1px solid black;>");
                            //html.Append(dr[7].ToString());
                            //html.Append("</td>");
                        }
                        else if ((dr[6].ToString().Contains("Total Amount")))
                        {
                            html.Append("<td style=\"border:0.25px solid black;text-align:right;\" colspan=\"4\">");
                            html.Append("Total Amount");
                            html.Append("</td>");

                            html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">");
                            html.Append(dr[9].ToString());
                            html.Append("</td>");
                        }
                    }

                    //html.Append("<td border: 1px solid black;>");
                    //html.Append(dr[4].ToString());
                    //html.Append("</td>");

                    //html.Append("<td border: 1px solid black;>");
                    //html.Append(dr[5].ToString());
                    //html.Append("</td>");

                    //if (dr[7] !=System.DBNull.Value)
                    //    Total = Total + Convert.ToDouble(dr[7]);

                    html.Append("</tr>");

                    counter++;
                }
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    html.Append("<tr>");
                    if (dr[0] != System.DBNull.Value & dr[0].ToString() != String.Empty)
                    {
                        html.Append("<td class=\"auto-style9\">");
                        html.Append(counter.ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style13\" style=\"text-align:left;\">");
                        html.Append(dr[0].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style19\" >");
                        html.Append(dr[1].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style18\" style=\"text-align:right;\">");
                        html.Append(dr[2].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style17\" style=\"text-align:right;\">");
                        html.Append(dr[3].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style22\" style=\"text-align:right;\">");
                        html.Append(dr[8].ToString());
                        html.Append("</td>");

                        html.Append("<td class=\"auto-style22\" style=\"text-align:right;\">");
                        html.Append(dr[7].ToString());
                        html.Append("</td>");


                    }
                    else
                    {
                        html.Append("<td style=\"border:0.25px solid black;text-align:right;\" colspan=\"7\">");
                        html.Append(dr[6].ToString());
                        html.Append("</td>");
                    }

                    html.Append("<td class=\"auto-style15\">");
                    html.Append(dr[9].ToString());
                    html.Append("</td>");

                    //if (dr[7] !=System.DBNull.Value)
                    //    Total = Total + Convert.ToDouble(dr[7]);

                    html.Append("</tr>");

                    counter++;
                }
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
        private void SetInvoiceHead(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
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
            int lenInvSubTitle4 = (int)g.MeasureString(InvSubTitle4, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;
            int xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2;
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
            if (InvSubTitle4 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle4, InvSubTitleFont, BlueBrush, xInvSubTitle4, CurrentY);
            }
            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);

            SetOrderData(g, e);
        }

        private void SetOrderData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {// Set Company Name, City, Salesperson, Order ID and Order Date


            string FieldValue = "";
            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
            // Set Company Name:
            CurrentX = leftMargin;
            CurrentY = CurrentY + 8;
            FieldValue = "Invoice No: " + InvoiceNo;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            ////// Set City:
            //CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            //FieldValue = "Customer Name: " + CustomerName;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            //// Set Salesperson:

            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Customer Name: " + CustomerName;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);


            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Contact Number: " + MobileNo;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Order ID:
            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Inventory Date: " + InvoicePrintDate;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Billing Address: " + BillingAddress;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Shipping Address: " + ShipingAddress;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            //// Set Order Date:
            //CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            //FieldValue = "Order Date: " + SaleDate;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            // Draw line:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);


            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Invoice Details:";
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



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
            foreach (DataGridViewColumn dgvGridCol in PrintGrid.Columns)
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
                foreach (DataGridViewColumn GridCol in PrintGrid.Columns)
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
            while (iRow <= PrintGrid.Rows.Count - 1)
            {
                DataGridViewRow GridRow = PrintGrid.Rows[iRow];
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

                        InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
                        // Set Company Name:

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
                        // CurrentY = CurrentY + InvoiceFontHeight + 8;
                        CurrentX = leftMargin;
                        CurrentY = CurrentY + InvoiceFontHeight;

                        g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);

                        iTopMargin = e.MarginBounds.Top + 310;
                        foreach (DataGridViewColumn GridCol in PrintGrid.Columns)
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
            InvTitle = ConfigurationManager.AppSettings["Company"].ToString();
            InvSubTitle1 = ConfigurationManager.AppSettings["Address"].ToString();
            InvSubTitle2 = ConfigurationManager.AppSettings["Phone"].ToString();
            InvSubTitle3 = ConfigurationManager.AppSettings["Email"].ToString();
            InvSubTitle4 = ConfigurationManager.AppSettings["GSTIN"].ToString();
            InvImage = Application.StartupPath + @"\Images\" + "InvPic.jpg";
        }
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;

            if (!ReadInvoice)
                FillDataGridForPrint();

            SetInvoiceHead(e.Graphics, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count >= 1)
            {
                string html;
                ReadInvoice = false;
                //if (!ReadInvoice)

                html = FillDataGridForPrint();

                Print(html);



                //PrintReport(); // Print Invoice
            }
            else
            {
                MessageBox.Show("Please add an item and then click on Print");
            }

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
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            string html;
            if (dataGridView2.Rows.Count >= 1)
            {
                ReadInvoice = false;

                html = FillDataGridForPrint();

                PrintPreview(html);
                // DisplayInvoice(); // Print Preview
            }
            else
            {
                MessageBox.Show("Please add an item and then click on Print Preview.");
            }
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
            if (wb.ReadyState.Equals(WebBrowserReadyState.Complete))
                wb.ShowPrintPreviewDialog();
            //else
            //    wb.ShowPrintPreviewDialog();
            //((WebBrowser)sender).ShowPrintPreviewDialog();
            //((WebBrowser)sender).Print();

            //((WebBrowser)sender).Dispose();
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width = 70;

			dtpInventoryDate.Format = DateTimePickerFormat.Custom;
            dtPaymentDate.Format = DateTimePickerFormat.Custom;
            dtReceivedDate.Format = DateTimePickerFormat.Custom;

            
            dtpInventoryDate.CustomFormat = ConfigurationManager.AppSettings["DateFormat"];
            dtPaymentDate.CustomFormat = ConfigurationManager.AppSettings["DateFormat"];
            dtReceivedDate.CustomFormat = ConfigurationManager.AppSettings["DateFormat"];
            string invPrefix = ConfigurationManager.AppSettings["InvoicePrefix"];

            string maxinvoiceID;

            DataTable dt = inventoryBLL.GetMax_Inventory();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    int maxID = 0;
                    int.TryParse(Convert.ToString(dt.Rows[0]["InvoiceID"]), out maxID);
                    maxinvoiceID = Convert.ToString(maxID + 1);
                    if (maxinvoiceID.Length == 1)
                    {
                        maxinvoiceID = invPrefix + "00" + maxinvoiceID;
                    }
                    else if (maxinvoiceID.Length == 2)
                    {
                        maxinvoiceID = invPrefix + "0" + maxinvoiceID;
                    }
                    else
                    {
                        maxinvoiceID = invPrefix + maxinvoiceID;
                    }
                }
                else
                {
                    maxinvoiceID = invPrefix + "001";
                }
                txtInvoiceNo.Text = maxinvoiceID;
            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumber(sender, e);
        }

        private void txtTaxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e);
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e);
        }

        private void gvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView2.DataSource = null;
            var senderGrid = (DataGridView)sender;

            var aa = gvInventory.CurrentCell.RowIndex;
            if (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 16)
            {
                InventoryID = Convert.ToInt32(gvInventory.Rows[aa].Cells[0].Value);

                DataTable dtInventory = new DataTable();
                dtInventory = inventoryBLL.GetAllInventory(InventoryID);
                if (dtInventory != null)
                {
                    if (dtInventory.Rows.Count > 0)
                    {
                        txtCompany.Text = Convert.ToString(dtInventory.Rows[0]["CompanyName"]);
                        txtContactPerson.Text = Convert.ToString(dtInventory.Rows[0]["ContactPersonName"]);
                        txtContactNumber.Text = Convert.ToString(dtInventory.Rows[0]["ContactNumber"]);
                        txtEmail.Text = Convert.ToString(dtInventory.Rows[0]["Email"]);
                        txtWebsite.Text = Convert.ToString(dtInventory.Rows[0]["Website"]);
                        cmbPaymentMode.SelectedValue = Convert.ToString(dtInventory.Rows[0]["PaymentModeID"]);
                        cmbIsPaid.SelectedValue = Convert.ToString(dtInventory.Rows[0]["IsPaid"]);
                        cmbIsOnCredit.SelectedValue = Convert.ToString(dtInventory.Rows[0]["IsOnCredit"]);
                        dtpInventoryDate.Text = Convert.ToString(dtInventory.Rows[0]["InventoryDate"]);
                        dtPaymentDate.Text = Convert.ToString(dtInventory.Rows[0]["PaymentDate"]);
                        dtReceivedDate.Text = Convert.ToString(dtInventory.Rows[0]["ItemsReceivedOn"]);
                        txtTaxAmount.Text = Convert.ToString(dtInventory.Rows[0]["TotalTaxAmount"]);
                        txtTotalAmount.Text = Convert.ToString(dtInventory.Rows[0]["TotalAmount"]);
                        txtRemark.Text = Convert.ToString(dtInventory.Rows[0]["Remarks"]);
                       txtInvoiceNo.Text = Convert.ToString(dtInventory.Rows[0]["InvoiceNo"]);
                        txtBillingAddress.Text = Convert.ToString(dtInventory.Rows[0]["BillingAddress"]);
                        txtShippingAddress.Text = Convert.ToString(dtInventory.Rows[0]["ShippingAddress"]);                    
                        txtGSTIN.Text = Convert.ToString(dtInventory.Rows[0]["GSTIN"]);
                    }

                    dtInventoryItem = new DataTable();
                    dtInventoryItem = inventoryBLL.GetAllInventoryItem(InventoryID, 0);
                    dataGridView2.AutoGenerateColumns = false;

                  //  dtInventoryItem.Columns.Add["NewRow"];
                    dataGridView2.DataSource = dtInventoryItem;
                    if (dtInventoryItem.Rows.Count > 0)
                    {
                        dataGridView2.Columns[3].ReadOnly = true;

                    }
                    txtTotal.Text = "";
                    decimal tltValue = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        // txtTotal.Text += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                        //tltValue += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                        tltValue += dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() == "" ? 0 : Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    }
                    txtTotal.Text = tltValue.ToString();
                    InvoiceTotal = Convert.ToDecimal(txtTotal.Text);
                    this.gvInventory.AllowUserToAddRows = false;
                    GetProduct();
                    GetUnit();

                }
            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 17 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(gvInventory.Rows[aa].Cells[0].Value.ToString()))))
            {
                InventoryID = Convert.ToInt32(gvInventory.Rows[aa].Cells[0].Value);
                bool check = inventoryBLL.DeleteInventory(InventoryID, 1);
                if (check == true)
                    MessageBox.Show("Selected Inventory Deleted Successfully.");
                else
                    MessageBox.Show("Selected Inventory cannot be deleted due to mapping with other masters.");

                ClearFields();
            }
            FillGrid();
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            //if (validation() == true)
            {
                DataTable dtInventory = new DataTable();
                dtInventory.TableName = "Inventory";
                dtInventory.Columns.Add("CompanyName", typeof(String));
                dtInventory.Columns.Add("ContactPersonName", typeof(String));
                dtInventory.Columns.Add("ContactNumber", typeof(String));
                dtInventory.Columns.Add("Email", typeof(String));
                dtInventory.Columns.Add("Website", typeof(String));
                dtInventory.Columns.Add("PaymentModeID", typeof(Int32));
                dtInventory.Columns.Add("PaymentMode", typeof(String));
                dtInventory.Columns.Add("IsPaid", typeof(Int32));
                dtInventory.Columns.Add("IsOnCredit", typeof(Int32));
                dtInventory.Columns.Add("InventoryDate", typeof(String));
                dtInventory.Columns.Add("PaymentDate", typeof(String));
                dtInventory.Columns.Add("ItemsReceivedOn", typeof(String));                
                dtInventory.Columns.Add("TotalTaxAmount", typeof(Int32));
                dtInventory.Columns.Add("TotalAmount", typeof(Int32));
                dtInventory.Columns.Add("Remarks", typeof(String));
                dtInventory.Columns.Add("InvoiceNo", typeof(String));
                dtInventory.Columns.Add("BillingAddress", typeof(String));
                dtInventory.Columns.Add("ShippingAddress", typeof(String));

                dtInventory.Columns.Add("GSTIN", typeof(String));

                DataRow rowInventory = dtInventory.NewRow();
                rowInventory["CompanyName"] = txtCompany.Text.Trim();
                rowInventory["ContactPersonName"] = txtContactPerson.Text.Trim();
                rowInventory["ContactNumber"] = txtContactNumber.Text.Trim();
                rowInventory["Email"] = txtEmail.Text.Trim();
                rowInventory["Website"] = txtWebsite.Text.Trim();
                rowInventory["PaymentModeID"] = 1;
                rowInventory["PaymentMode"] = "Cash";
                rowInventory["IsPaid"] = 1;
                rowInventory["IsOnCredit"] = 1;
                rowInventory["InventoryDate"] = Convert.ToDateTime(dtpInventoryDate.Value).ToString("MM-dd-yy"); 
                rowInventory["PaymentDate"] = Convert.ToDateTime(dtPaymentDate.Value).ToString("MM-dd-yy");
                rowInventory["ItemsReceivedOn"] = Convert.ToDateTime(dtReceivedDate.Value).ToString("MM-dd-yy");
                rowInventory["TotalTaxAmount"] = Convert.ToInt32(txtTaxAmount.Text);
                rowInventory["TotalAmount"] = Convert.ToInt32(txtTotalAmount.Text);
                rowInventory["Remarks"] = txtRemark.Text.Trim();
                rowInventory["InvoiceNo"] = txtInvoiceNo.Text.Trim();
                rowInventory["BillingAddress"] = txtBillingAddress.Text.Trim();
                rowInventory["ShippingAddress"] = txtShippingAddress.Text.Trim();              
                rowInventory["GSTIN"] = txtGSTIN.Text.Trim();
                dtInventory.Rows.Add(rowInventory);

                DataTable dtInventoryItems = new DataTable();
                dtInventoryItems.TableName = "InventoryDetails";
                dtInventoryItems.Columns.Add("InventoryItemID", typeof(Int32));
                dtInventoryItems.Columns.Add("InventoryID", typeof(Int32));
                dtInventoryItems.Columns.Add("ProductID", typeof(Int32));
                dtInventoryItems.Columns.Add("Product", typeof(String));
                dtInventoryItems.Columns.Add("Make", typeof(String));
                dtInventoryItems.Columns.Add("Quantity", typeof(Decimal));
                dtInventoryItems.Columns.Add("UnitID", typeof(String));
                dtInventoryItems.Columns.Add("SizeId", typeof(Int32));
                dtInventoryItems.Columns.Add("Size", typeof(String));
                dtInventoryItems.Columns.Add("RatePerUnit", typeof(Decimal));
                dtInventoryItems.Columns.Add("TaxID", typeof(Int32));
                dtInventoryItems.Columns.Add("HSN_SAC", typeof(Int32));
                dtInventoryItems.Columns.Add("TaxPercentage", typeof(Int32));
                dtInventoryItems.Columns.Add("TaxAmount", typeof(Decimal));
                dtInventoryItems.Columns.Add("Discount", typeof(Decimal));
                dtInventoryItems.Columns.Add("DiscountAmount", typeof(Decimal));
                dtInventoryItems.Columns.Add("TotalAmount", typeof(Decimal));
                dtInventoryItems.Columns.Add("Remark", typeof(String));
                dtInventoryItems.Columns.Add("Delete", typeof(Boolean));
                //Added 
              //  dtInventoryItems.Columns.Add("IsNew", typeof(Boolean));

                DataRow row;
                for (int i = 0; i <dataGridView2.Rows.Count; i++)
                {
                    row = dtInventoryItems.NewRow();

                    row["InventoryItemID"] = dataGridView2.Rows[i].Cells["InventoryItemID"].Value.ToString() == "" ? "0" : dataGridView2.Rows[i].Cells["InventoryItemID"].Value;

                    row["InventoryID"] = InventoryID;
                    row["ProductID"] = dataGridView2.Rows[i].Cells["Product"].Value;
                    row["Product"] = Convert.ToString(dataGridView2.Rows[i].Cells["Product"].Value);
                    row["Make"] = Convert.ToString(dataGridView2.Rows[i].Cells["Make"].Value);
                    row["Quantity"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Quantity"].Value);

                    row["UnitID"] = Convert.ToString(dataGridView2.Rows[i].Cells["Unit"].Value);
                    row["TaxID"] = Convert.ToInt32(dataGridView2.Rows[i].Cells["TaxID"].Value);
                    if (Convert.ToInt32(dataGridView2.Rows[i].Cells["Size"].Value) > 0)
                    {
                        row["SizeId"] = Convert.ToInt32(dataGridView2.Rows[i].Cells["Size"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Please select size for the selected product.");
                        isValid = false;
                    }
                    row["RatePerUnit"] = Convert.ToInt32(dataGridView2.Rows[i].Cells["RateperUnit"].Value);
                    if (Convert.ToString(dataGridView2.Rows[i].Cells["HSN_SAC"].Value) != "")
                        row["HSN_SAC"] = Convert.ToInt32(dataGridView2.Rows[i].Cells["HSN_SAC"].Value);
                    else
                    {
                        row["HSN_SAC"] = DBNull.Value;
                    }
                    row["TaxPercentage"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Tax"].Value);
                    row["Discount"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Discount"].Value);

                    if (Convert.ToString(dataGridView2.Rows[i].Cells["TaxAmt"].Value) != "")
                    {
                        row["TaxAmount"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["TaxAmt"].Value);
                    }
                    else
                    {
                        row["TaxAmount"] = 0;
                    }
                    if (Convert.ToString(dataGridView2.Rows[i].Cells["DiscountAmt"].Value) != "")
                    {
                        row["DiscountAmount"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["DiscountAmt"].Value);
                    }
                    else
                    {
                        row["DiscountAmount"] = 0;
                    }
                    if (Convert.ToString(dataGridView2.Rows[i].Cells["TotalAmt"].Value) != "")
                    {
                        row["TotalAmount"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    }
                    else
                    {
                        row["TotalAmount"] = 0;
                    }

                    row["Remark"] = Convert.ToString(dataGridView2.Rows[i].Cells["Remark"].Value);
                    DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    ch1 = (DataGridViewCheckBoxCell)dataGridView2.Rows[i].Cells[0];
                    row["Delete"] = ch1.Value == null ? false : true;
                  //  row["IsNew"] = true;
                    dtInventoryItems.Rows.Add(row);
                }

                System.IO.StringWriter swSQL;                
                StringBuilder sbSQL1 = new StringBuilder();
                swSQL = new System.IO.StringWriter(sbSQL1);
                dtInventoryItems.WriteXml(swSQL);
                swSQL.Dispose();

                System.IO.StringWriter swSQL2;
                StringBuilder sbSQL2 = new StringBuilder();
                swSQL2 = new System.IO.StringWriter(sbSQL2);
                dtInventory.WriteXml(swSQL2);
                swSQL2.Dispose();

                if (isValid)
                {
                    inventoryBLL.InventorySave(InventoryID, sbSQL2.ToString(), sbSQL1.ToString(), UserId);

                    InventoryID = 0;
                    ClearFields();
                    FillGrid();
                    this.dataGridView2.DataSource = null;
                }

            }
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRow newRow;
            DataTable dtItem = new DataTable();
            DataTable tdExistRows = (DataTable)dataGridView2.DataSource;
            if (dtInventoryItem == null)
            {
                dtItem = new DataTable();
                dtItem.TableName = "InvoiceDetails";
                dtItem.Columns.Add("InventoryItemID", typeof(Int32));
                dtItem.Columns.Add("InventoryID", typeof(Int32));
                dtItem.Columns.Add("ProductID", typeof(Int32));
                dtItem.Columns.Add("Product", typeof(String));
                dtItem.Columns.Add("Make", typeof(String));
                dtItem.Columns.Add("Quantity", typeof(Decimal));
                dtItem.Columns.Add("UnitID", typeof(String));
                dtItem.Columns.Add("SizeId", typeof(Int32));
                dtItem.Columns.Add("Size", typeof(String));
                dtItem.Columns.Add("RatePerUnit", typeof(Decimal));
                dtItem.Columns.Add("TaxID", typeof(Int32));
                dtItem.Columns.Add("HSN_SAC", typeof(Int32));                
                dtItem.Columns.Add("TaxPercentage", typeof(Int32));
                dtItem.Columns.Add("TaxAmount", typeof(Decimal));
                dtItem.Columns.Add("Discount", typeof(String));
                dtItem.Columns.Add("DiscountAmount", typeof(Decimal));
                dtItem.Columns.Add("TotalAmount", typeof(Decimal));
                dtItem.Columns.Add("Remark", typeof(String));
                dtItem.Columns.Add("Delete", typeof(Boolean));
                dtItem.Columns.Add("IsNew", typeof(Boolean));

                newRow = dtItem.NewRow();
                dtItem.Rows.Add(newRow);

                dataGridView2.AutoGenerateColumns = false;
              

                if (tdExistRows != null)
                {
                    newRow = tdExistRows.NewRow();
                    newRow["IsNew"] = true;
                    tdExistRows.Rows.Add(newRow);
                }
                else
                {
                    tdExistRows = dtItem;
                }
                dataGridView2.DataSource = tdExistRows;

                this.gvInventory.AllowUserToAddRows = false;
                GetSingleProduct(dataGridView2.Rows.Count - 1);
                GetSingleUnit(dataGridView2.Rows.Count - 1);
            }
            else
            {
                newRow = tdExistRows.NewRow();
                tdExistRows.Rows.Add(newRow);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = tdExistRows;
                this.gvInventory.AllowUserToAddRows = false;
                GetSingleProduct(dataGridView2.Rows.Count - 1);
                GetSingleUnit(dataGridView2.Rows.Count - 1);
            }


        }
        private void GetUnit()
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllUnit(null);
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "UnitID ASC";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewComboBoxCell obj = new DataGridViewComboBoxCell();
                obj = (DataGridViewComboBoxCell)dataGridView2.Rows[i].Cells["Unit"];
                var data = dataGridView2.Rows[i].Cells["UnitID"].Value;
                var selectValue = 0;
                if (data != null)
                {
                    if (data.ToString() != string.Empty)
                        selectValue = Convert.ToInt32(data);
                }
                obj.DataSource = dt;
                obj.ValueMember = "UnitID";
                obj.DisplayMember = "Name";
                obj.Value = selectValue;

                DataTable dtZise = new DataTable();
                dtZise = sizeBLL.GetAllSize(null, selectValue);
                dtZise.Rows.Add(new object[] { 0, "Select" });
                dtZise.DefaultView.Sort = "SizeId ASC";

                DataGridViewComboBoxCell objSize = new DataGridViewComboBoxCell();
                objSize = (DataGridViewComboBoxCell)dataGridView2.Rows[i].Cells["Size"];
                var dataSize = dataGridView2.Rows[i].Cells["SizeId"].Value;
                selectValue = 0;
                if (data != null)
                {
                    if (dataSize.ToString() != string.Empty)
                        selectValue = Convert.ToInt32(dataSize);
                }
                objSize.DataSource = dtZise;
                objSize.ValueMember = "SizeID";
                objSize.DisplayMember = "SizeName";
                objSize.Value = selectValue;

                // GetSize(selectValue);

            }
        }
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in dataGridView2.Rows.Cast<DataGridViewRow>()
                                                  select row).ToList();

            foreach (DataGridViewRow item in selectedRows)
            {
                if (item.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(item.Cells[0].Value) == true)
                        dataGridView2.Rows.RemoveAt(item.Index);
                }

            }
            txtTotal.Text = "";
            decimal tltValue = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                // txtTotal.Text += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                if (dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() != "")
                {
                   // tltValue += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    tltValue += dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() == "" ? 0 : Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                }
            }
            txtTotal.Text = tltValue.ToString();
            InvoiceTotal = Convert.ToDecimal(txtTotal.Text);

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Sorry we are unable to procceed dut to this " + e.Exception.Message.ToString());
        }


        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            }
            if (dataGridView2.CurrentCell.ColumnIndex == ConstProduct && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
            if ((dataGridView2.CurrentCell.ColumnIndex == ConstQuantity) && e.Control is TextBox)
            {
                TextBox txtQuantity = e.Control as TextBox;
                txtQuantity.TextChanged += txtQuantity_TextChanged;
            }
            if (dataGridView2.CurrentCell.ColumnIndex == ConstRate && e.Control is TextBox)
            {
                TextBox txtRate = e.Control as TextBox;
                //txtRate.TextChanged += txtRate_TextChanged;
                txtRate.Leave += txtRate_TextChanged;
            }
            if (dataGridView2.CurrentCell.ColumnIndex == ConstDiscount && e.Control is TextBox)
            {
                TextBox txtDiscount = e.Control as TextBox;
                txtDiscount.TextChanged += txtDiscount_TextChanged;
            }
            if (dataGridView2.CurrentCell.ColumnIndex == ConstTax && e.Control is TextBox)
            {
                TextBox txtTax = e.Control as TextBox;
                txtTax.TextChanged += txtTax_TextChanged;
            }
            if (dataGridView2.CurrentCell.ColumnIndex == ConstUnit && e.Control is ComboBox)
            {
                ComboBox comboBoxUnit = e.Control as ComboBox;
                comboBoxUnit.SelectedIndexChanged += LastColumnComboUnitSelectionChanged;
            }

        }
        private void LastColumnComboUnitSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView2.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;

            DataGridViewComboBoxCell sizedll = (DataGridViewComboBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstSize];
            if (currentcell.X == ConstUnit)
            {
                if (sendingCB.SelectedValue != null && sendingCB.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    DataTable dt = new DataTable();
                    dt = sizeBLL.GetAllSize(null, Convert.ToInt32(sendingCB.SelectedValue));
                    dt.Rows.Add(new object[] { 0, "Select" });
                    dt.DefaultView.Sort = "SizeId ASC";

                    var selectValue = 0;

                    sizedll.DataSource = dt;
                    sizedll.ValueMember = "SizeID";
                    sizedll.DisplayMember = "SizeName";
                    sizedll.Value = selectValue;
                }
            }
        }
        // TextBox TextChanged Event
        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == ConstTax)
            {
                var currentcell = dataGridView2.CurrentCellAddress;
                var sendingTB = sender as DataGridViewTextBoxEditingControl;
                DataGridViewTextBoxCell Rate = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTax];
                DataGridViewTextBoxCell discount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscount];
                DataGridViewTextBoxCell discountAmt = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscountAmount];
                DataGridViewTextBoxCell Quantity = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstQuantity];
                DataGridViewTextBoxCell TaxAmount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTaxAmount];
                DataGridViewTextBoxCell Total = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTotal];
                decimal outValue = 0;
                Decimal.TryParse(sendingTB.Text, out outValue);

                decimal QuantityRate=0;
                decimal dicountPer = 0;
                
                if (Quantity.Value!= System.DBNull.Value && Rate.Value!= System.DBNull.Value)
                { 
                 QuantityRate = Convert.ToDecimal(Quantity.Value) * Convert.ToDecimal(Rate.Value);
                }
                if(QuantityRate!=0 && discount.Value!=null)
                { 
                    dicountPer = QuantityRate / 100 * Convert.ToDecimal(discount.Value);
                }
                if(dicountPer!=0)
                { 
                discountAmt.Value = Convert.ToDecimal(dicountPer);
                }

                decimal totalafterDiscount = QuantityRate - dicountPer;

                decimal totalTax = totalafterDiscount / 100 * Convert.ToDecimal(outValue);
                TaxAmount.Value = totalTax;
                Total.Value = Convert.ToDecimal(totalafterDiscount + totalTax);
                txtTotal.Text = "";
                decimal tltValue = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    // txtTotal.Text += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    //tltValue += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    tltValue += dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() == "" ? 0 : Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                }
                txtTotal.Text = tltValue.ToString();
                InvoiceTotal = Convert.ToDecimal(txtTotal.Text);
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == ConstDiscount)
            {
                var currentcell = dataGridView2.CurrentCellAddress;
                var sendingTB = sender as DataGridViewTextBoxEditingControl;
                DataGridViewTextBoxCell Rate = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstRate];
                DataGridViewTextBoxCell Quantity = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstQuantity];
                DataGridViewTextBoxCell discountAmt = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscount];
                DataGridViewTextBoxCell Tax = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTax];
                DataGridViewTextBoxCell TaxAmount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTaxAmount];
                DataGridViewTextBoxCell Total = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTotal];

                decimal outValue = 0;
                Decimal.TryParse(sendingTB.Text, out outValue);

                decimal QuantityRate = 0;
        
                if (Quantity.Value!= System.DBNull.Value && Rate.Value!= System.DBNull.Value)
                {
                 QuantityRate = Convert.ToDecimal(Quantity.Value) * Convert.ToDecimal(Rate.Value);
                }

                decimal dicountPer = QuantityRate / 100 * Convert.ToDecimal(outValue);
                discountAmt.Value = Convert.ToDecimal(dicountPer);

                decimal totalafterDiscount = QuantityRate - dicountPer;

                decimal totalTax = totalafterDiscount / 100 * Convert.ToDecimal(Tax.Value);
                TaxAmount.Value = totalTax;
                Total.Value = Convert.ToDecimal(totalafterDiscount + totalTax);
                txtTotal.Text = "";
                decimal tltValue = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    // txtTotal.Text += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    //tltValue += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    tltValue += dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() == "" ? 0 : Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                }
                txtTotal.Text = tltValue.ToString();
                InvoiceTotal = Convert.ToDecimal(txtTotal.Text);
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == ConstQuantity)
            {
                var currentcell = dataGridView2.CurrentCellAddress;
                var sendingTB = sender as DataGridViewTextBoxEditingControl;
                DataGridViewTextBoxCell Rate = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstRate];
                DataGridViewTextBoxCell discount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscount];
                DataGridViewTextBoxCell discountAmt = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscountAmount];
                DataGridViewTextBoxCell Tax = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTax];
                DataGridViewTextBoxCell TaxAmount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTaxAmount];
                DataGridViewTextBoxCell Total = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTotal];
                decimal outValue = 0;
                decimal QuantityRate=0;
                decimal dicountPer = 0;
                Decimal.TryParse(sendingTB.Text, out outValue);
                if(Rate.Value!= System.DBNull.Value)
                { 
               QuantityRate = outValue * Convert.ToDecimal(Rate.Value);
                }

                if(discount.Value!=System.DBNull.Value)
                { 
                dicountPer = QuantityRate / 100 * Convert.ToDecimal(discount.Value);
                }
                discountAmt.Value = Convert.ToDecimal(dicountPer);

                decimal totalafterDiscount = QuantityRate - dicountPer;
                decimal totalTax = 0;
                if (Tax.Value !=System.DBNull.Value)
                {
                    totalTax = totalafterDiscount / 100 * Convert.ToDecimal(Tax.Value);
                }
                TaxAmount.Value = totalTax;
                Total.Value = Convert.ToDecimal(totalafterDiscount + totalTax);
                txtTotal.Text = "";
                decimal tltValue = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    // txtTotal.Text += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                   // tltValue += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    tltValue += dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() == "" ? 0 : Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                }
                txtTotal.Text = tltValue.ToString();
                InvoiceTotal = Convert.ToDecimal(txtTotal.Text);

            }
        }
        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == ConstRate)
            {
                var currentcell = dataGridView2.CurrentCellAddress;
                var Rate = sender as DataGridViewTextBoxEditingControl;
                DataGridViewTextBoxCell sendingTB = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstRate];
                DataGridViewTextBoxCell discount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscount];
                DataGridViewTextBoxCell discountAmt = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstDiscountAmount];
                DataGridViewTextBoxCell Tax = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTax];
                DataGridViewTextBoxCell TaxAmount = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTaxAmount];
                DataGridViewTextBoxCell Total = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTotal];
                DataGridViewTextBoxCell quantity = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstQuantity];
                decimal outValue = 0;
                Decimal.TryParse(Rate.Text, out outValue);
                //   Decimal.TryParse(quantity.Text, out outValue);


                // decimal QuantityRate = Convert.ToDecimal(sendingTB.Value) * outValue;

                decimal QuantityRate = 0;
                decimal dicountPer = 0;
                if (quantity.Value!=System.DBNull.Value)
                { 
                QuantityRate= Convert.ToDecimal(sendingTB.EditedFormattedValue) * (Decimal)quantity.Value;
                }
                if(discount.Value!=System.DBNull.Value)
                {
                 dicountPer = QuantityRate / 100 * Convert.ToDecimal(discount.Value);
                }
                discountAmt.Value = Convert.ToDecimal(dicountPer);

                decimal totalafterDiscount = QuantityRate - dicountPer;

                decimal totalTax = 0;
                if(Tax.Value !=System.DBNull.Value)
                { 
                 totalTax = totalafterDiscount / 100 * Convert.ToDecimal(Tax.Value);
                }
                TaxAmount.Value = totalTax;
                Total.Value = Convert.ToDecimal(totalafterDiscount + totalTax);
                txtTotal.Text = "";
                decimal tltValue = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    // txtTotal.Text += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    //tltValue += Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                    tltValue += dataGridView2.Rows[i].Cells["TotalAmt"].Value.ToString() == "" ? 0 : Convert.ToDecimal(dataGridView2.Rows[i].Cells["TotalAmt"].Value);
                }
                txtTotal.Text = tltValue.ToString();
                InvoiceTotal = Convert.ToDecimal(txtTotal.Text);
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView2.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstTaxID];
            DataGridViewComboBoxCell unitdll = (DataGridViewComboBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstUnit];
            DataGridViewComboBoxCell sizedll = (DataGridViewComboBoxCell)dataGridView2.Rows[currentcell.Y].Cells[ConstSize];
            if (currentcell.X == ConstProduct)
            {
                if (sendingCB.SelectedValue != null && sendingCB.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    cel.Value = sendingCB.SelectedValue;
                    DataTable dtProduct = new DataTable();
                    if (Convert.ToInt32(cel.Value) > 0)
                    {
                        dtProduct = productBLL.GetAllProduct(Convert.ToInt32(cel.Value));
                        var row = this.dataGridView2.Rows[currentcell.Y];
                        if (dtProduct != null)
                        {
                            if (dtProduct.Rows.Count > 0)
                            {
                                row.Cells["ProductID"].Value = dtProduct.Rows[0]["ProductID"];
                                row.Cells["SizeID"].Value = dtProduct.Rows[0]["SizeID"];
                                row.Cells["TaxID"].Value = dtProduct.Rows[0]["TaxID"];
                                row.Cells["Make"].Value = dtProduct.Rows[0]["Make"];
                                row.Cells["HSN_SAC"].Value = dtProduct.Rows[0]["HSN_SAC"];
                                row.Cells[ConstQuantity].Value = 0;
                                row.Cells[10].Value = 0;
                                row.Cells["UnitID"].Value = dtProduct.Rows[0]["UnitID"];
                                unitdll.Value = dtProduct.Rows[0]["UnitID"];

                                DataTable dt = new DataTable();
                                dt = sizeBLL.GetAllSize(null, Convert.ToInt32(dtProduct.Rows[0]["UnitID"]));
                                dt.Rows.Add(new object[] { 0, "Select" });
                                dt.DefaultView.Sort = "SizeId ASC";



                                sizedll.DataSource = dt;
                                sizedll.ValueMember = "SizeID";
                                sizedll.DisplayMember = "SizeName";


                                sizedll.Value = dtProduct.Rows[0]["SizeID"];
                                // row.Cells[10].Value = 0;
                                row.Cells["RatePerUnit"].Value = dtProduct.Rows[0]["RatePerUnit"];
                                //
                                // row.Cells[11].Value = dtProduct.Rows[0]["SizeName"];
                                row.Cells[ConstTax].Value = dtProduct.Rows[0]["TaxPercentage"];
                                row.Cells[15].Value = 0;
                                row.Cells[ConstDiscount].Value = dtProduct.Rows[0]["Discount"];
                                row.Cells[17].Value = 0;
                                row.Cells[18].Value = 0;
                                row.Cells[ConstRemark].Value = dtProduct.Rows[0]["Remark"];

                            }
                        }

                    }
                }
            }
        }


        private void chkSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSameAddress.Checked)
            {
                txtShippingAddress.Text = txtBillingAddress.Text;
                txtShippingAddress.Enabled = false;
            }
            else
            {
                txtShippingAddress.Enabled = true;
                txtShippingAddress.Text = "";
            }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        #endregion [Events] 

        #region [FillGrid] 

        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = inventoryBLL.GetAllInventory(0);
            GridBind(dt);
        }

        private void GridBind(DataTable dt)
        {
            gvInventory.AutoGenerateColumns = false;
            dt.Columns.Add("Edit");
            gvInventory.DataSource = dt;            
            this.gvInventory.AllowUserToAddRows = false;
        }

        #endregion [FillGrid]

        #region [Combo Fill] 
        private void GetAllPaymentMode()
        {
            DataTable dt = new DataTable();
            dt = inventoryBLL.GetAllPaymentMode();
            cmbPaymentMode.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "PaymentModeID";
            cmbPaymentMode.ValueMember = "PaymentModeID";
            cmbPaymentMode.DisplayMember = "PaymentMode";
            cmbPaymentMode.SelectedValue = 0;
        }

        private void GetAllIsPaid()
        {            
            cmbIsPaid.Items.Insert(0, "Yes");
            cmbIsPaid.Items.Insert(1, "No");            
            cmbIsPaid.ValueMember = "IsPaidID";
            cmbIsPaid.DisplayMember = "IsPaid";
            cmbIsPaid.SelectedIndex = 0;
            cmbIsPaid.SelectedValue = 0;
        }

        private void GetAllIsOnCredit()
        {
           
            cmbIsOnCredit.ValueMember = "IsOnCreditID";
            cmbIsOnCredit.DisplayMember = "IsOnCredit";
            cmbIsOnCredit.SelectedIndex = 0;
            cmbIsOnCredit.SelectedValue = 0;
        }

        private void GetProduct()
        {
            DataTable dt = new DataTable();
            dt = inventoryBLL.GetProduct();
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "ProductID ASC";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewComboBoxCell obj = new DataGridViewComboBoxCell();
                obj = (DataGridViewComboBoxCell)dataGridView2.Rows[i].Cells["Product"];
                var data = dataGridView2.Rows[i].Cells["ProductID"].Value;
                var selectValue = 0;
                if (data.ToString() != string.Empty)
                    selectValue = Convert.ToInt32(data);
                obj.DataSource = dt;
                obj.ValueMember = "ProductID";
                obj.DisplayMember = "ProductName";
                obj.Value = selectValue;
            }
        }
        private void GetSingleProduct(int index)
        {
            DataTable dt = new DataTable();
            dt = inventoryBLL.GetProduct();
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "ProductID ASC";

            DataGridViewComboBoxCell obj = new DataGridViewComboBoxCell();
            obj = (DataGridViewComboBoxCell)dataGridView2.Rows[index].Cells["Product"];
            var data = dataGridView2.Rows[index].Cells["ProductID"].Value;
            var selectValue = 0;
            if (data.ToString() != string.Empty)
                selectValue = Convert.ToInt32(data);
            obj.DataSource = dt;
            obj.ValueMember = "ProductID";
            obj.DisplayMember = "ProductName";
            obj.Value = selectValue;


        }
        private void GetSingleUnit(int Index)
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllUnit(null);
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "UnitID ASC";

            DataGridViewComboBoxCell obj = new DataGridViewComboBoxCell();
            obj = (DataGridViewComboBoxCell)dataGridView2.Rows[Index].Cells["Unit"];
            var data = dataGridView2.Rows[Index].Cells["UnitID"].Value;
            var selectValue = 0;
            if (data != null)
            {
                if (data.ToString() != string.Empty)
                    selectValue = Convert.ToInt32(data);
            }
            obj.DataSource = dt;
            obj.ValueMember = "UnitID";
            obj.DisplayMember = "Name";
            obj.Value = selectValue;
            GetSingleSize(selectValue, Index);


        }
        private void GetSize(int? unitId)
        {
            DataTable dt = new DataTable();
            dt = sizeBLL.GetAllSize(null, unitId);
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "SizeId ASC";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewComboBoxCell obj = new DataGridViewComboBoxCell();
                obj = (DataGridViewComboBoxCell)dataGridView2.Rows[i].Cells["Size"];
                var data = dataGridView2.Rows[i].Cells["SizeId"].Value;
                var selectValue = 0;
                if (data != null)
                {
                    if (data.ToString() != string.Empty)
                        selectValue = Convert.ToInt32(data);
                }
                obj.DataSource = dt;
                obj.ValueMember = "SizeID";
                obj.DisplayMember = "SizeName";
                obj.Value = selectValue;

            }
        }
        private void GetSingleSize(int? unitId, int index)
        {
            DataTable dt = new DataTable();
            dt = sizeBLL.GetAllSize(null, unitId);
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "SizeId ASC";

            DataGridViewComboBoxCell obj = new DataGridViewComboBoxCell();
            obj = (DataGridViewComboBoxCell)dataGridView2.Rows[index].Cells["Size"];
            var data = dataGridView2.Rows[index].Cells["SizeId"].Value;
            var selectValue = 0;
            if (data != null)
            {
                if (data.ToString() != string.Empty)
                    selectValue = Convert.ToInt32(data);
            }
            obj.DataSource = dt;
            obj.ValueMember = "SizeID";
            obj.DisplayMember = "SizeName";
            obj.Value = selectValue;


        }
        private void FillCombo()
        {
            GetAllPaymentMode();
            GetAllIsOnCredit();
            GetAllIsPaid();
            GetProduct();
            GetUnit();

        }

        #endregion [Combo Fill] 

        #region [ClearFields] 

        private void ClearFields()
        {
            string invPrefix = ConfigurationManager.AppSettings["InvoicePrefix"];

            string maxinvoiceID;

            DataTable dt = inventoryBLL.GetMax_Inventory();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    int maxID = 0;
                    int.TryParse(Convert.ToString(dt.Rows[0]["InvoiceID"]), out maxID);
                    maxinvoiceID = Convert.ToString(maxID + 1);
                    if (maxinvoiceID.Length == 1)
                    {
                        maxinvoiceID = invPrefix + "00" + maxinvoiceID;
                    }
                    else if (maxinvoiceID.Length == 2)
                    {
                        maxinvoiceID = invPrefix + "0" + maxinvoiceID;
                    }
                    else
                    {
                        maxinvoiceID = invPrefix + maxinvoiceID;
                    }
                }
                else
                {
                    maxinvoiceID = invPrefix + "001";
                }
                txtInvoiceNo.Text = maxinvoiceID;
            }
            txtCompany.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtWebsite.Text = string.Empty;
            cmbPaymentMode.SelectedValue = 0;
            cmbIsOnCredit.SelectedValue = 0;
            cmbIsPaid.SelectedValue = 0;
            txtRemark.Text = string.Empty;
            dtReceivedDate.Value = DateTime.Now;
            dtpInventoryDate.Value = DateTime.Now;
            dtPaymentDate.Value = DateTime.Now;
            txtTotalAmount.Text = "0";
            txtTaxAmount.Text = "0";
            InventoryID = 0;
        }

        #endregion [ClearFields] 

        #region [Validation] 

        public void onlynumwithsinglepoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        public void onlynumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))               
            {
                e.Handled = true;
            }

        }



		#endregion [Validation] 

		#region Utility Methods

		public string ConvertNumbertoWords(long number)
		{



			if (number == 0) return "ZERO";
			if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
			string words = "";
			if ((number / 1000000) > 0)
			{
				words += ConvertNumbertoWords(number / 100000) + " LAKES ";
				number %= 1000000;
			}
			if ((number / 1000) > 0)
			{
				words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
				number %= 1000;
			}
			if ((number / 100) > 0)
			{
				words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
				number %= 100;
			}
			//if ((number / 10) > 0)  
			//{  
			// words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
			// number %= 10;  
			//}  
			if (number > 0)
			{
				if (words != "") words += "AND ";
				var unitsMap = new[]
				{
					"ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
				};
				var tensMap = new[]
				{
					"ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
				};
				if (number < 20) words += unitsMap[number];
				else
				{
					words += tensMap[number / 10];
					if ((number % 10) > 0) words += " " + unitsMap[number % 10];
				}
			}
			return words;
		}
		#endregion

		private void chkSameAddress_CheckedChanged_1(object sender, EventArgs e)
		{
			if (chkSameAddress.Checked)
			{
				txtShippingAddress.Text = txtBillingAddress.Text;
				txtShippingAddress.Enabled = false;
			}
			else
			{
				txtShippingAddress.Enabled = true;
				txtShippingAddress.Text = "";
			}
		}
	}
}
