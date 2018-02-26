using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

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
           
        }
        public void LoadComboBox(String SQL,ComboBox cbo)
        {
            cbo.Items.Clear();
            //
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(SQL, cnn);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cbo.Items.Add(read.GetString(1));
                }

                this.CloseConnection();
            }

        }
        private bool OpenConnection()
        {
            try
            {
                cnn.Open();
             
                return true;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                cnn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string query)
        {


            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Select statement
        public void Select(string query,DataGridView dgv)
        {
          
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                //Create a data reader and Execute the command
                DataTable tbl = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter(query,cnn);
                adp.Fill(tbl);
                dgv.DataSource = tbl;
                
                //close Data Reader
                

                //close Connection
                this.CloseConnection();

                //return list to be displayed
             
            }
            else
            {
                return;
            }
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
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);
              
                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                
            }
            return true;
        }
        public bool hasRegistered(string query)
        {
            if (this.OpenConnection() == true)
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
                else { reader.Close(); cnn.Close(); return false; }                   

            }
           
                return true;
        }

        public enum UserStatus
        {
            IsRegistered,
            IsNotRegistered,
            UserCheckFailed
        }
        public bool IsLogin(string query)
        {
            if (this.OpenConnection() == true)
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
            return true;
        }
        
    }
}
