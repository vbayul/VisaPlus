using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VisaPlus
{
    class UserDataSet
    {
        private string cmd = "";
        private MySqlConnection myConnection = new MySqlConnection();
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter da;
        private DataSet ds;

        public DataSet getDSUser()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();

            // дописать иф для админа и простого манагера
            cmd = "SELECT idusers, username,password,idtype,status,email "
                + " FROM pass.users;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@userid", Param.getUserID());

            da.SelectCommand = myCommand;
            try
            {
                myConnection.Open();
                da.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }
            finally
            {
                myConnection.Close();
            }

            return ds;
        }
    }
}
