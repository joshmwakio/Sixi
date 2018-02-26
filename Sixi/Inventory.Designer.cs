namespace Sixi
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockAndBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data1 = new Sixi.Data();
            this.suppliers1 = new Sixi.Suppliers();
            this.products1 = new Sixi.Products();
            this.category1 = new Sixi.Category();
            this.stock_and_Barcode1 = new Sixi.Stock_and_Barcode();
            this.invoice1 = new Sixi.Invoice();
            this.view_Sales_Invoice1 = new Sixi.View_Sales_Invoice();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 56);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(629, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventory";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.prontingToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockAndBarcodeToolStripMenuItem,
            this.stockReturnToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // stockAndBarcodeToolStripMenuItem
            // 
            this.stockAndBarcodeToolStripMenuItem.Name = "stockAndBarcodeToolStripMenuItem";
            this.stockAndBarcodeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.stockAndBarcodeToolStripMenuItem.Text = "Stock and Barcode";
            this.stockAndBarcodeToolStripMenuItem.Click += new System.EventHandler(this.stockAndBarcodeToolStripMenuItem_Click);
            // 
            // stockReturnToolStripMenuItem
            // 
            this.stockReturnToolStripMenuItem.Name = "stockReturnToolStripMenuItem";
            this.stockReturnToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.stockReturnToolStripMenuItem.Text = "Stock return";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInvoiceToolStripMenuItem});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.newInvoiceToolStripMenuItem.Text = "New Invoice";
            this.newInvoiceToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesInvoiceToolStripMenuItem,
            this.viewStockReturnToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewSalesInvoiceToolStripMenuItem
            // 
            this.viewSalesInvoiceToolStripMenuItem.Name = "viewSalesInvoiceToolStripMenuItem";
            this.viewSalesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.viewSalesInvoiceToolStripMenuItem.Text = "View Sales invoice";
            this.viewSalesInvoiceToolStripMenuItem.Click += new System.EventHandler(this.viewSalesInvoiceToolStripMenuItem_Click);
            // 
            // viewStockReturnToolStripMenuItem
            // 
            this.viewStockReturnToolStripMenuItem.Name = "viewStockReturnToolStripMenuItem";
            this.viewStockReturnToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.viewStockReturnToolStripMenuItem.Text = "View Stock Return";
            // 
            // prontingToolStripMenuItem
            // 
            this.prontingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printBillToolStripMenuItem,
            this.printCustomerDetailsToolStripMenuItem});
            this.prontingToolStripMenuItem.Name = "prontingToolStripMenuItem";
            this.prontingToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.prontingToolStripMenuItem.Text = "Printing";
            // 
            // printBillToolStripMenuItem
            // 
            this.printBillToolStripMenuItem.Name = "printBillToolStripMenuItem";
            this.printBillToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.printBillToolStripMenuItem.Text = "Print Bill";
            // 
            // printCustomerDetailsToolStripMenuItem
            // 
            this.printCustomerDetailsToolStripMenuItem.Name = "printCustomerDetailsToolStripMenuItem";
            this.printCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.printCustomerDetailsToolStripMenuItem.Text = "Print Customer Details";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profitsToolStripMenuItem,
            this.lossToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.cashSaleToolStripMenuItem,
            this.customersReportToolStripMenuItem,
            this.supplierReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // profitsToolStripMenuItem
            // 
            this.profitsToolStripMenuItem.Name = "profitsToolStripMenuItem";
            this.profitsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.profitsToolStripMenuItem.Text = "Profits report";
            this.profitsToolStripMenuItem.Click += new System.EventHandler(this.profitsToolStripMenuItem_Click);
            // 
            // lossToolStripMenuItem
            // 
            this.lossToolStripMenuItem.Name = "lossToolStripMenuItem";
            this.lossToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.lossToolStripMenuItem.Text = "Loss report";
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.invoicesToolStripMenuItem.Text = "Invoices report";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.stockReportToolStripMenuItem.Text = "Stock report";
            // 
            // cashSaleToolStripMenuItem
            // 
            this.cashSaleToolStripMenuItem.Name = "cashSaleToolStripMenuItem";
            this.cashSaleToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.cashSaleToolStripMenuItem.Text = "Cash Sale report";
            // 
            // customersReportToolStripMenuItem
            // 
            this.customersReportToolStripMenuItem.Name = "customersReportToolStripMenuItem";
            this.customersReportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.customersReportToolStripMenuItem.Text = "Customers Report";
            // 
            // supplierReportToolStripMenuItem
            // 
            this.supplierReportToolStripMenuItem.Name = "supplierReportToolStripMenuItem";
            this.supplierReportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.supplierReportToolStripMenuItem.Text = "Supplier Report";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpToolStripMenuItem,
            this.userLogHistoryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.backUpToolStripMenuItem.Text = "BackUp";
            // 
            // userLogHistoryToolStripMenuItem
            // 
            this.userLogHistoryToolStripMenuItem.Name = "userLogHistoryToolStripMenuItem";
            this.userLogHistoryToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.userLogHistoryToolStripMenuItem.Text = "User-Log History";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // data1
            // 
            this.data1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.data1.Location = new System.Drawing.Point(3, 53);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(724, 539);
            this.data1.TabIndex = 1;
            // 
            // suppliers1
            // 
            this.suppliers1.Location = new System.Drawing.Point(0, 53);
            this.suppliers1.Name = "suppliers1";
            this.suppliers1.Size = new System.Drawing.Size(724, 526);
            this.suppliers1.TabIndex = 2;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.products1.Location = new System.Drawing.Point(-1, 52);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(725, 540);
            this.products1.TabIndex = 3;
            // 
            // category1
            // 
            this.category1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.category1.Location = new System.Drawing.Point(62, 73);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(632, 461);
            this.category1.TabIndex = 4;
            // 
            // stock_and_Barcode1
            // 
            this.stock_and_Barcode1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.stock_and_Barcode1.Location = new System.Drawing.Point(-3, 53);
            this.stock_and_Barcode1.Name = "stock_and_Barcode1";
            this.stock_and_Barcode1.Size = new System.Drawing.Size(724, 539);
            this.stock_and_Barcode1.TabIndex = 5;
            // 
            // invoice1
            // 
            this.invoice1.Location = new System.Drawing.Point(-3, 53);
            this.invoice1.Name = "invoice1";
            this.invoice1.Size = new System.Drawing.Size(724, 539);
            this.invoice1.TabIndex = 6;
            // 
            // view_Sales_Invoice1
            // 
            this.view_Sales_Invoice1.Location = new System.Drawing.Point(0, 53);
            this.view_Sales_Invoice1.Name = "view_Sales_Invoice1";
            this.view_Sales_Invoice1.Size = new System.Drawing.Size(724, 539);
            this.view_Sales_Invoice1.TabIndex = 7;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 612);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.suppliers1);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.stock_and_Barcode1);
            this.Controls.Add(this.invoice1);
            this.Controls.Add(this.view_Sales_Invoice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockAndBarcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lossToolStripMenuItem;
        private Data data1;
        private Suppliers suppliers1;
        private Products products1;
        private Category category1;
        private Stock_and_Barcode stock_and_Barcode1;
        private Invoice invoice1;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private View_Sales_Invoice view_Sales_Invoice1;
    }
}