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
        private MySqlConnection myConnect = new MySqlConnection();
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter da;
        private DataSet ds;

        public DataSet proxyDS()
        {
            cmd = "SELECT idproxy, proxystatus, proxyip, proxyport FROM pass.proxy "
                + " WHERE proxyuser = @userid";

            da = new MySqlDataAdapter();
            ds = new DataSet();
            myConnect.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnect;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@userid", Param.getUserID());

            da.SelectCommand = myCommand;

            try
            {
                myConnect.Open();
                da.Fill(ds);
                myConnect.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }

            return ds;
        }
    }
}
