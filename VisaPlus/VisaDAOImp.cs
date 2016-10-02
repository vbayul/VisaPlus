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
        private MySqlConnection myConnection = new MySqlConnection(Param.getConnectionString());
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataReader dr;
        private MySqlDataAdapter da;
        private DataSet ds;

        public bool addVisa(Visa visa)
        {
            cmd = "INSERT INTO `pass`.`client` "
                +"(`visitdate`,`status`,`region`,`title`,`firstname`,`lastname`,"
                +"`dob`,`email`,`password`,`passport`,`passportexpire`,`clientticket`,`visatype`,"
                +"`nationality`,`purpose`,`persons`,`kids`,`payed`,`travellength`,`nearestdate`,`userid`)"
                // значения которые необходимо внести
                +" VALUES(visitdate,status,region,title,firstname,lastname,dob,email,password,"
                +"passport,passportexpire,clientticket,visatype,nationality,purpose,"
                +"persons,kids,payed,travellength,nearestdate,userid);";

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@clientstatus", visa.getClientStatus());
            myCommand.Parameters.AddWithValue("@clientname", visa.getClientName());
            myCommand.Parameters.AddWithValue("@clientticket", visa.getClientTicket());
            myCommand.Parameters.AddWithValue("@userid", Param.getUserID());

            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                saccess = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }

            return saccess;
        }
        public bool saveVisa(Visa visa)
        {
            cmd = "UPDATE `pass`.`client` SET "
                + " `clientname` = @clientname, "
                + " `clientticket` = @clientticket "
                + " WHERE `idclient` = @idclient;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@clientname", visa.getClientName());
            myCommand.Parameters.AddWithValue("@clientticket", visa.getClientTicket());
            myCommand.Parameters.AddWithValue("@idclient", visa.getClientId());

            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                saccess = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }

            return saccess;
        }

        public Visa getVisa(string id)
        {
            cmd = "SELECT idclient, clientstatus,clientname, clientticket "
            + " FROM pass.client WHERE idclient = @idclient";

            da = new MySqlDataAdapter();
            ds = new DataSet();
            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@idclient", id);

            da.SelectCommand = myCommand;

            Visa visa = new Visa();
            try
            {
                myConnection.Open();
                dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    visa = new Visa(dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(3), dr.GetInt32(1).ToString());
                }
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка осединения с БД.");
            }

            return visa;
        }
    }
}