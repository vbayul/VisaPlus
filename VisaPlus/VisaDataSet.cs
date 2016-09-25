﻿using System;
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
        private MySqlConnection myConnect = new MySqlConnection();
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter da;
        private DataSet ds;

        public DataSet getDSVisa()
        {
            da = new MySqlDataAdapter();
            ds = new DataSet();

            cmd = "SELECT * FROM pass.client WHERE userid = @userid";

            myConnect.ConnectionString = User.getConnectionString();
            myCommand.Connection = myConnect;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@userid", User.getUserID());

            da.SelectCommand = myCommand;

            myConnect.Open();
            da.Fill(ds);
            myConnect.Close();

            return ds;
        }

        public DataSet searchDSVisa(string id)
        {
            cmd = "SELECT * FROM pass.client WHERE userid = @userid and clientid = @clientid";

            da = new MySqlDataAdapter();
            ds = new DataSet();
            myConnect.ConnectionString = User.getConnectionString();
            myCommand.Connection = myConnect;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@userid", User.getUserID());
            myCommand.Parameters.AddWithValue("@clientid", id);

            da.SelectCommand = myCommand;

            myConnect.Open();
            da.Fill(ds);
            myConnect.Close();

            return ds;
        }
    }
}
