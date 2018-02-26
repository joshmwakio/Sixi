using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sixi
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void profitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data customers = new Data();
            customers.BringToFront();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.BringToFront();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.BringToFront();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.BringToFront();
        }

        private void stockAndBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_and_Barcode stock_ = new Stock_and_Barcode();
            stock_.BringToFront();
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.BringToFront();
        }

        private void viewSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Sales_Invoice view = new View_Sales_Invoice();
            view.BringToFront();
        }
    }
}
