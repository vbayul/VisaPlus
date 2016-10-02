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
                +" VALUES(@visitdate,@status,@region,@title,@firstname,@lastname,@dob,@email,@password,"
                +"@passport,@passportexpire,@clientticket,@visatype,@nationality,@purpose,"
                + "@persons,@kids,@payed,@travellength,@nearestdate,@userid);";

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();
            MessageBox.Show(visa.getstatus());
            myCommand.Parameters.AddWithValue("@visitdate", visa.getvisitdate());
            myCommand.Parameters.AddWithValue("@status", visa.getstatus());
            myCommand.Parameters.AddWithValue("@region", visa.getregion());
            myCommand.Parameters.AddWithValue("@title", visa.gettitle());
            myCommand.Parameters.AddWithValue("@firstname", visa.getfirstname());
            myCommand.Parameters.AddWithValue("@lastname", visa.getlastname());
            myCommand.Parameters.AddWithValue("@dob", visa.getdob());
            myCommand.Parameters.AddWithValue("@email", visa.getemail());
            myCommand.Parameters.AddWithValue("@password", visa.getpassword());
            myCommand.Parameters.AddWithValue("@passport", visa.getpassport());
            myCommand.Parameters.AddWithValue("@passportexpire", visa.getpassportexpire());
            myCommand.Parameters.AddWithValue("@clientticket", visa.getclientticket());
            myCommand.Parameters.AddWithValue("@visatype", visa.getvisatype());
            myCommand.Parameters.AddWithValue("@nationality", visa.getnationality());
            myCommand.Parameters.AddWithValue("@purpose", visa.getpurpose());
            myCommand.Parameters.AddWithValue("@persons", visa.getpersons());
            myCommand.Parameters.AddWithValue("@kids", visa.getkids());
            myCommand.Parameters.AddWithValue("@payed", visa.getpayed());
            myCommand.Parameters.AddWithValue("@travellength", visa.gettravellength());
            myCommand.Parameters.AddWithValue("@nearestdate", visa.getnearestdate());
            myCommand.Parameters.AddWithValue("@userid", Param.getUserID());

            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                saccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка соединения с БД." + ex);
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

            myCommand.Parameters.AddWithValue("@clientname", visa);
            myCommand.Parameters.AddWithValue("@clientticket", visa);
            myCommand.Parameters.AddWithValue("@idclient", visa);

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
                MessageBox.Show("Произошла ошибка соединения с БД.");
            }

            return saccess;
        }

        public Visa getVisa(string id)
        {
            cmd = "SELECT idclient, clientstatus,clientname, clientticket "
            + " FROM pass.client WHERE idclient = @idclient";

            da = new MySqlDataAdapter();

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
                    //visa = new Visa(dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(3), dr.GetInt32(1).ToString());
                    // дописать момент заполение полей в объекте
                }
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка соединения с БД.");
            }

            return visa;
        }
    }
}