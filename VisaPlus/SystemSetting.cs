using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace VisaPlus
{
    class SystemSetting
    {
        private string cmd = "";
        private MySqlConnection myConnection = new MySqlConnection(Param.getConnectionString());
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataReader dr;
        //private MySqlDataAdapter da;
        public string getValue(string param)
        {
            cmd = "SELECT `settingparam`,`settingvalue` "
                + " FROM `pass`.`setting` WHERE settingparam = @settingparam";

            //da = new MySqlDataAdapter();
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@settingparam", param);

            //da.SelectCommand = myCommand;

            string value = "";
            try
            {
                myConnection.Open();
                dr = myCommand.ExecuteReader();
                while (dr.Read())
                {

                    value = dr.GetString(1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }
            finally
            {
                myConnection.Close();
            }

            return value;
        }
        public void setValue(string param, string value)
        {
            cmd = "UPDATE `pass`.`setting` SET `settingvalue` = @settingvalue"
                + " WHERE settingparam = @settingparam";

            //da = new MySqlDataAdapter();
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@settingparam", param);
            myCommand.Parameters.AddWithValue("@settingvalue", value);
            //da.SelectCommand = myCommand;

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
