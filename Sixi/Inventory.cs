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
            data1.BringToFront();
            
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suppliers1.BringToFront();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products1.BringToFront();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category1.BringToFront();
        }

        private void stockAndBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_and_Barcode1.BringToFront();
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice1.BringToFront();
        }

        private void viewSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_Sales_Invoice1.BringToFront();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
