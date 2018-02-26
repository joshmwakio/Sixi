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
    public partial class MainMenu : Form
    {
        public MainMenu(string Username,String Level)
        {
            InitializeComponent();
            label4.Text = Username;
            label5.Text = Level;
            if(Level == "User")
            {
                register.Enabled = true;
                edit.Enabled = false;
                reports.Enabled = false;
                process.Enabled = false;
            }
            else if(Level == "Admin")
            {
                register.Enabled = true;
                edit.Enabled = true;
                reports.Enabled = true;
                process.Enabled = true;
            }
            else if (Level == "Guest")
            {
                register.Enabled = false;
                edit.Enabled = false;
                reports.Enabled = false;
                process.Enabled = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void process_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
           
        }
    }
}
