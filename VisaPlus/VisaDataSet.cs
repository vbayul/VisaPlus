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

        public DataSet getDSVisa(string manager)
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            myCommand.Parameters.Clear();

            if (Param.getAccess() == "0")
            {
                // дописать иф для админа и простого манагера
                cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                       + " FROM pass.client INNER JOIN pass.users "
                       + " ON userid = idusers WHERE userid = @userid";
                myCommand.Parameters.AddWithValue("@userid", Param.getUserID());
            }
            else
            {
                if (manager == "0")
                {
                    cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                        + " FROM pass.client INNER JOIN pass.users "
                        + " ON userid = idusers";
                }
                else
                {
                    cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                        + " FROM pass.client INNER JOIN pass.users "
                        + " ON userid = idusers WHERE userid = @userid";
                    myCommand.Parameters.AddWithValue("@userid", manager);
                }
            }
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

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

        public DataSet searchDSVisa(string search, string manager)
        {
            /*
            cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                   + " FROM pass.client INNER JOIN pass.users "
                   + " ON userid = idusers WHERE userid = @userid and clientname like @search;";
            */

            myCommand.Parameters.Clear();

            if (Param.getAccess() == "0")
            {
                // дописать иф для админа и простого манагера
                cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                       + " FROM pass.client INNER JOIN pass.users "
                       + " ON userid = idusers WHERE userid = @userid and clientname like @search;";
                myCommand.Parameters.AddWithValue("@userid", Param.getUserID());
            }
            else
            {
                if (manager == "0")
                {
                    cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                        + " FROM pass.client INNER JOIN pass.users "
                        + " ON userid = idusers and clientname like @search;";
                }
                else
                {
                    cmd = "SELECT idclient,clientstatus,clientname,clientticket,users.username "
                        + " FROM pass.client INNER JOIN pass.users "
                        + " ON userid = idusers WHERE userid = @userid and clientname like @search;";
                    myCommand.Parameters.AddWithValue("@userid", manager);
                }
            }

            da = new MySqlDataAdapter();
            ds = new DataSet();
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

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
