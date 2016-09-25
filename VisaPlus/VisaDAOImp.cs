using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VisaPlus
{
    class VisaDAOImp : VisaDAO
    {
        private string cmd = "";
        private MySqlConnection myConnect = new MySqlConnection(User.getConnectionString());
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataReader dr;
        private MySqlDataAdapter da;
        private DataSet ds;

        public bool addVisa(Visa visa)
        {
            cmd = "INSERT INTO `pass`.`client` (`clientstatus`,`clientname`,`clientticket`,`userid`) "
                    + " VALUES (@clientstatus, @clientname, @clientticket, @userid);";
            
            myCommand.Connection = myConnect;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@clientstatus", visa.getClientStatus());
            myCommand.Parameters.AddWithValue("@clientname", visa.getClientName());
            myCommand.Parameters.AddWithValue("@clientticket", visa.getClientTicket());
            myCommand.Parameters.AddWithValue("@userid", User.getUserID());

            bool saccess = false;
            try
            {
                myConnect.Open();
                myCommand.ExecuteNonQuery();
                myConnect.Close();
                saccess = true;
            }
            catch (Exception)
            {

            }

            return saccess;
        }
        public bool saveVisa(Visa visa)
        {
            cmd = "UPDATE `pass`.`client` SET "
                + " `clientname` = @clientname, "
                + " `clientticket` = @clientticket "
                + " WHERE `idclient` = @idclient;";

            myConnect.ConnectionString = User.getConnectionString();
            myCommand.Connection = myConnect;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@clientname", visa.getClientName());
            myCommand.Parameters.AddWithValue("@clientticket", visa.getClientTicket());
            myCommand.Parameters.AddWithValue("@idclient", visa.getClientId());

            bool saccess = false;
            try
            {
                myConnect.Open();
                myCommand.ExecuteNonQuery();
                myConnect.Close();
                saccess = true;
            }
            catch (Exception)
            {

            }

            return saccess;
        }

        public Visa getVisa(string id)
        {
            cmd = "SELECT idclient, clientstatus,clientname, clientticket "
            + " FROM pass.client WHERE idclient = @idclient";

            da = new MySqlDataAdapter();
            ds = new DataSet();
            myConnect.ConnectionString = User.getConnectionString();
            myCommand.Connection = myConnect;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@idclient", id);

            da.SelectCommand = myCommand;

            Visa visa = new Visa(); 
            myConnect.Open();
                dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    visa = new Visa(dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(3), dr.GetInt32(1).ToString());
                }
            myConnect.Close();

            return visa;
        }


    }
}
