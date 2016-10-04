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
                cmd = "SELECT `idclient`,`visitdate`,`status`,`firstname`,`lastname`,`dob`,"
                    +"`passport`,`passportexpire`,`clientticket`,`payed`,`username`"
                    +" FROM `pass`.`client_view` WHERE userid = @userid";
                myCommand.Parameters.AddWithValue("@userid", Param.getUserID());
            }
            else
            {
                if (manager == "0")
                {
                    cmd = "SELECT `idclient`,`visitdate`,`status`,`firstname`,`lastname`,`dob`,"
                    + "`passport`,`passportexpire`,`clientticket`,`payed`,`username`"
                    + " FROM `pass`.`client_view` ";
                }
                else
                {
                    cmd = "SELECT `idclient`,`visitdate`,`status`,`firstname`,`lastname`,`dob`,"
                    + "`passport`,`passportexpire`,`clientticket`,`payed`,`username`"
                    + " FROM `pass`.`client_view`  WHERE userid = @userid";
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

        public DataSet searchDSVisa(string search, string manager)
        {
            myCommand.Parameters.Clear();

            if (Param.getAccess() == "0")
            {
                // дописать иф для админа и простого манагера
                cmd = "SELECT `idclient`,`visitdate`,`status`,`firstname`,`lastname`,`dob`,"
                    + "`passport`,`passportexpire`,`clientticket`,`payed`,`username`"
                    + " FROM `pass`.`client_view` WHERE userid = @userid and firstname like @search or firstname like @search ;";
                myCommand.Parameters.AddWithValue("@userid", Param.getUserID());
            }
            else
            {
                if (manager == "0")
                {
                    cmd = "SELECT `idclient`,`visitdate`,`status`,`firstname`,`lastname`,`dob`,"
                    + "`passport`,`passportexpire`,`clientticket`,`payed`,`username`"
                    + " FROM `pass`.`client_view` WHERE firstname like @search or firstname like @search ;";
                }
                else
                {
                    cmd = "SELECT `idclient`,`visitdate`,`status`,`firstname`,`lastname`,`dob`,"
                    + "`passport`,`passportexpire`,`clientticket`,`payed`,`username`"
                    + " FROM `pass`.`client_view` WHERE userid = @userid and firstname like @search or firstname like @search ;";
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