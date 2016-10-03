using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace VisaPlus
{
    class Setting
    {
        private string cmd = "";
        MySqlConnection myConnection = new MySqlConnection();
        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataReader dr;

        public string getValue(string param)
        {
            cmd = "SELECT settingvalue FROM pass.setting WHERE settingparam = @settingparam;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@settingparam", param);

            string url = "";
            try
            {
                myConnection.Open();
                dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    url = dr.GetString(0);
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
            return url;
        }

        public void setValue(string value, string param)
        {
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.Parameters.Clear();

            cmd = "UPDATE pass.setting SET settingvalue = @settingvalue WHERE settingparam = @settingparam;";
            myCommand.Parameters.AddWithValue("@settingvalue", value);
            myCommand.Parameters.AddWithValue("@settingparam", param);
            myCommand.CommandText = cmd;

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
