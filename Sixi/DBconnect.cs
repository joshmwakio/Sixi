using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace Sixi
{
    class DBconnect
    {
        MySqlConnection cnn;
        public DBconnect()
        {
            string connectionString = null;

            connectionString = "server=localhost;database=school;uid=Josh;pwd=0721466024jm.";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();

        }
        public void LoadComboBox(String SQL, ComboBox cbo)
        {
            cbo.Items.Clear();

            MySqlCommand cmd = new MySqlCommand(SQL, cnn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cbo.Items.Add(read.GetString(0));
            }
            read.Close();
            cnn.Close();
        }
        public void LoadTextBox(string Sql, TextBox text)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            MySqlCommand cmd = new MySqlCommand(Sql, cnn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                collection.Add(read.GetString(0));

            }
            text.AutoCompleteCustomSource = collection;
            text.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            read.Close();
            cnn.Close();
        }


        //Close connectioN

        //Insert statement
        public void Insert(string query)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            //Execute command
            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        //Update statement
        public void Update(string query)
        {

            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            //Execute command
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        //Delete statement
        public void Delete(string query)
        {

            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            //Execute command
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        //Select statement
        public void Select(string query, DataGridView dgv)
        {


            //Create Command
            //Create a data reader and Execute the command
            DataTable tbl = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(query, cnn);
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            cnn.Close();

        }

        //Count statement
        //public int Count()
        //{
        //}

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
        public bool Register(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            //Execute command
            cmd.ExecuteNonQuery();
            cnn.Close();
            return true;
        }
        public bool hasRegistered(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                cnn.Close();
                return true;

            }
            else { reader.Close(); cnn.Close(); return false; }


        }
        public void LoadImage(string query, PictureBox picture)
        {
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string path = Application.StartupPath + @"\Images\" + read.GetString(0);

                if (File.Exists(path))
                {
                    picture.Tag = path;
                    picture.Image = Image.FromFile(path);
                }
                else
                {
                    picture.Tag = read.GetString(0);
                    picture.Image = null;
                }

            }

            read.Close();
            cnn.Close();
        }


        public bool IsLogin(string query)
        {

            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                cnn.Close();

                return true;

            }
            else
            {
                reader.Close();
                cnn.Close();
                return false;

            }

        }
    }
}
