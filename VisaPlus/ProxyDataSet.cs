using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VisaPlus
{
    class ProxyDataSet
    {
        private string cmd = "";
        private MySqlConnection myConnection = new MySqlConnection();
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter da;
        private DataSet ds;

        public DataSet proxyDS()
        {
            cmd = "SELECT idproxy, proxystatus, proxyip, proxyport FROM proxy "
                + " WHERE proxyuser = @userid";

            da = new MySqlDataAdapter();
            ds = new DataSet();
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
            finally
            {
                myConnection.Close();
            }

            return ds;
        }
    }
}
