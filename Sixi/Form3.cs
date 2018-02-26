using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sixi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = username.Text;
            String Password = password.Text;
            DBconnect db = new DBconnect();
           // pictureBox1.Visible = true;
            if (db.hasRegistered($"SELECT * FROM users WHERE Username='{Username}'") ==false)
            {
                
                db.Register($"INSERT INTO users (Username,Password) VALUES('{Username}','{Password}')");
               // pictureBox1.Visible = false;
                DialogResult result = MessageBox.Show("Successfully Registerd", "Secured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("User Exists", "Secured", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  pictureBox1.Visible = false;
            }
            
        
        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.Trim()))
            {
                infor.Visible = true;
                infor.BackColor = Color.IndianRed;
               
                label4.Text = "Please Provide Your Username !";
                  username.Focus();

            }
            else if (string.IsNullOrEmpty(password.Text.Trim()))
            {
                infor.Visible = true;
                label4.Text = "Please Provide Your Password !";
              
                password.Focus();
            }
            else
            {
                String Username = username.Text;
                String Password = password.Text;
                String Level = level.Text;
                DBconnect db = new DBconnect();
                //Clipboard.SetText($" SELECT * FROM users WHERE Username = '{Username}'AND Password = '{Password}' AND Level = '{level}'");

                if (db.IsLogin($"SELECT * FROM users WHERE Username='{Username}'AND Password='{Password}' AND Level='{Level}'"))

                {
                      new MainMenu(username.Text,level.Text).ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password/Username Incorrect", "Secured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
