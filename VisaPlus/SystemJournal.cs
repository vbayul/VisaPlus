using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace VisaPlus
{
    class SystemJournal
    {
        private string cmd = "";
        MySqlConnection myConnection = new MySqlConnection(Param.getConnectionString());
        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataAdapter da;
        DataSet ds;

        public DataSet getLogin()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            cmd = "SELECT idusers, username FROM pass.users WHERE status = 0 ORDER BY username;";

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
                MessageBox.Show("Ошибка подключения к БД.");
            }

            return ds;
        }

        public DataSet getRegion()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            cmd = "SELECT `idregion`,`nameregion` FROM `pass`.`region` ORDER BY `idregion`;";

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
                MessageBox.Show("Ошибка подключения к БД.");
            }

            return ds;
        }
        public DataSet getPurpose()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            cmd = "SELECT `idpurposes`,`namepurposes`FROM `pass`.`purposes` ORDER BY `idpurposes`;";

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
                MessageBox.Show("Ошибка подключения к БД.");
            }

            return ds;
        }

        public DataSet getVisaType()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            cmd = "SELECT `idvisatype`,`namevisatype` FROM `pass`.`visatype` ORDER BY `idvisatype`;";

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
                MessageBox.Show("Ошибка подключения к БД.");
            }
            return ds;
        }

        public DataSet getNationality()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            cmd = "SELECT `idnationality`, `nationality` FROM `pass`.`nationality` ORDER BY `idnationality`;";

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
                MessageBox.Show("Ошибка подключения к БД.");
            }
            finally
            {
                myConnection.Close();
            }

            return ds;
        }
        public DataSet getTitle()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();
            cmd = "SELECT `idtitle`,`nametitle` FROM `pass`.`title` ORDER BY `idtitle`;";

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
                MessageBox.Show("Ошибка подключения к БД.");
            }
            finally
            {
                myConnection.Close();
            }
            return ds;
        }
    }
}
