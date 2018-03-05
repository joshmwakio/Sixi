using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sixi
{
    public partial class Data : UserControl
    {
        public string imagesPath = Application.StartupPath + @"\Images\";

        private static string filepath = "";

        public Data()
        {
            DBconnect dBconnect = new DBconnect();
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }
        
        private void Data_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dBconnect.LoadTextBox("SELECT * FROM customers", textBox1);

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string ext = Path.GetExtension(filepath);
            if (string.IsNullOrEmpty(bunifuMaterialTextbox1.Text.Trim()) && string.IsNullOrEmpty(bunifuMaterialTextbox2.Text.Trim()) && string.IsNullOrEmpty(bunifuMaterialTextbox3.Text.Trim()))
            {
                MessageBox.Show("You must provide all fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DBconnect dBconnect = new DBconnect();
               void insert() {
                    dBconnect.Insert($"INSERT INTO customers (CustomerName,Mobile,Address,Picture) VALUES('{bunifuMaterialTextbox1.Text}','{bunifuMaterialTextbox2.Text}','{bunifuMaterialTextbox3.Text}','{pictureBox1.Tag}')");
                    dBconnect.Select("SELECT * FROM  customers", dataGridView1);
                    dataGridView1.Update();
                }
               
                if (pictureBox1.Image == null)
                {
                    insert();

                }
                else
                {    
                    
                    File.Copy(filepath, imagesPath + bunifuMaterialTextbox2.Text + ext, true);
                    pictureBox1.Tag =bunifuMaterialTextbox2.Text + ext;
                    insert();

                }

            }

            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
          

        }

        private void UpdatebunifuFlatButton_Click(object sender, EventArgs e)
        {
            DBconnect dBconnect = new DBconnect();
            dBconnect.Update($"UPDATE customers SET Mobile={bunifuMaterialTextbox2.Text},Address={bunifuMaterialTextbox3.Text},Picture={pictureBox1.Image} WHERE CustomerName='{bunifuMaterialTextbox1.Text}'");
        }

        private void DeletebunifuFlatButton_Click(object sender, EventArgs e)
        {
            DBconnect dBconnect = new DBconnect();
            dBconnect.Delete($"DELETE FROM customers WHERE CustomerName='{bunifuMaterialTextbox1.Text}'");

        }

        private void UploadbunifuFlatButton_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog fileDialog = new OpenFileDialog();
            //string Destination = imagesPath + bunifuMaterialTextbox1.Text + Path.GetExtension(fileDialog.FileName);
           

            fileDialog.Filter = "Picture Files|*.jpg|All Files|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(fileDialog.FileName);
                pictureBox1.Image = image;
                filepath = fileDialog.FileName;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBconnect dBconnect = new DBconnect();

            int index = e.RowIndex;
            
            DataGridViewRow row = dataGridView1.Rows[index];
            bunifuMaterialTextbox1.Text = row.Cells[0].Value.ToString();
            bunifuMaterialTextbox2.Text = row.Cells[1].Value.ToString();
            bunifuMaterialTextbox3.Text = row.Cells[2].Value.ToString();
            dBconnect.LoadImage($"SELECT Picture FROM customers WHERE id='{row.Cells[0].Value.ToString()}'", pictureBox1);
            toolStripStatusLabel1.Text = (row.Cells[e.ColumnIndex].Value.ToString());
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int index;
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {    
            // dataGridView1.Rows[e.RowIndex].Selected = true;
            // dataGridView1.Update();
            // label3.Text = dataGridView1.Rows[e.RowIndex].ToString();
            // MessageBox.Show(e.RowIndex.ToString());
            // dataGridView1.Sort(dataGridView1.Columns["Mobile"], ListSortDirection.Ascending);
            // dataGridView1.Rows[index].Selected = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBconnect dBconnect = new DBconnect();
            dBconnect.Select($"Select * FROM customers WHERE id={comboBox1.Text}", dataGridView1);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DBconnect dBconnect = new DBconnect();
            dBconnect.Select($"SELECT * FROM customers WHERE CustomerName LIKE '{textBox1.Text + "%"}'", dataGridView1);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DBconnect dBconnect = new DBconnect();
            dBconnect.LoadTextBox("SELECT CustomerName FROM customers", textBox1);
            DBconnect bconnect = new DBconnect();
            bconnect.LoadComboBox("SELECT id FROM customers", comboBox1);


            DBconnect dBcconnect = new DBconnect();
            dBcconnect.Select("SELECT * FROM  customers", dataGridView1);
            dataGridView1.Sort(dataGridView1.Columns["Mobile"], ListSortDirection.Ascending);

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "ExcelFile|*.xls";
            if (save.ShowDialog()== DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                excel.Columns.ColumnWidth = 13;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excel.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.ActiveWorkbook.SaveCopyAs(save.FileName.ToString());
                excel.ActiveWorkbook.Saved = true;
                excel.Quit();
            }
        }
    }
}