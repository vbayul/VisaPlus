using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VisaPlus
{
    class ProxyDAOImp : ProxyDAO
    {
        private string cmd = "";
        MySqlConnection myConnection = new MySqlConnection();
        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;

        public void saveProxy(string ip, string port)
        {
            cmd = "INSERT INTO proxy (proxyip,proxyport,proxyuser,proxystatus) "
                + " VALUES (@proxyip,@proxyport,@proxyuser,@proxystatus);";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@proxyip", ip);
            myCommand.Parameters.AddWithValue("@proxyport", port);
            myCommand.Parameters.AddWithValue("@proxyuser", Param.getUserID());
            myCommand.Parameters.AddWithValue("@proxystatus", "0");

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }
        }
        public void setProxy(string id)
        {
            cmd = "UPDATE proxy SET proxystatus = 0; UPDATE proxy SET proxystatus = 1 WHERE idproxy = @idproxy";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@idproxy", id);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }
        }
        public Proxy getProxy()
        {
            cmd = "SELECT idproxy,proxyip,proxyport, proxyuser, proxystatus "
                + " FROM pass.proxy "
                + " WHERE proxystatus = 1 and proxyuser = @proxyuser";

            da = new MySqlDataAdapter();
            ds = new DataSet();

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@proxyuser", Param.getUserID());

            da.SelectCommand = myCommand;

            Proxy proxy = new Proxy();
            try
            {
                myConnection.Open();
                dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    proxy.setProxyIP(dr.GetString(1));
                    proxy.setProxyPort(dr.GetString(2));
                }
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }
            return proxy;
        }
    }
}
