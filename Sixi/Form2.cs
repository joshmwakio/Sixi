using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sixi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //load the combobox
            DBconnect DB = new DBconnect();
            DB.LoadComboBox("SELECT * FROM users ",name);
        }

        private void pb_userimg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string RegNumber = textBox2.Text;

            DBconnect db = new DBconnect();
            db.Insert("INSERT INTO students (Name, RegistrationNumber) VALUES('"+Name+"', '"+RegNumber+"')");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string RegNumber = textBox2.Text;

            DBconnect db = new DBconnect();
            db.Update($"UPDATE students SET RegistrationNumber={RegNumber} WHERE Name='john'");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            db.Delete("DELETE FROM students WHERE name='john'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            db.Select("SELECT * FROM students", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            DBconnect DB = new DBconnect();
            DB.LoadComboBox("SELECT id FROM customers ", comboBox1);
        }
    }
}
