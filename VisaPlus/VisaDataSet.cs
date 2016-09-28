using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace VisaPlus
{
    class VisaDataSet
    {
        private string cmd = "";
        private MySqlConnection myConnection = new MySqlConnection();
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter da;
        private DataSet ds;

        public DataSet getDSVisa()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();

            // дописать иф для админа и простого манагера
            cmd = "SELECT * FROM pass.client WHERE userid = @userid";

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
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }

            return ds;
        }

        public DataSet searchDSVisa(string search)
        {
            cmd = @"SELECT * FROM pass.client WHERE userid = @userid and clientname like @search;";

            da = new MySqlDataAdapter();
            ds = new DataSet();
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@userid", Param.getUserID());
            myCommand.Parameters.AddWithValue("@search", "%" + search + "%");
            
            da.SelectCommand = myCommand;
            try
            {
                myConnection.Open();
                da.Fill(ds);
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }

            return ds;
        }
    }
}
