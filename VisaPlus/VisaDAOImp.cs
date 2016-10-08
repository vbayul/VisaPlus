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

        public bool addVisa(Visa visa)
        {
            cmd = "INSERT INTO `pass`.`client` "
                + "(`visitdate`,`status`,`region`,`title`,`firstname`,`lastname`,"
                + "`dob`,`email`,`password`,`passport`,`passportexpire`,`clientticket`,`visatype`,"
                + "`nationality`,`purpose`,`persons`,`kids`,`payed`,`travellength`,`nearestdate`,`userid`)"
                + " VALUES(@visitdate,@status,@region,@title,@firstname,@lastname,@dob,@email,@password,"
                + "@passport,@passportexpire,@clientticket,@visatype,@nationality,@purpose,"
                + "@persons,@kids,@payed,@travellength,@nearestdate,@userid);";

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();
            myCommand = commandParam(myCommand, visa, false);
            /*
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
            */
            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                saccess = true;
            }
            catch (Exception)
            {
                //MessageBox.Show("Произошла ошибка соединения с БД." + ex);
            }
            finally
            {
                myConnection.Close();
            }

            return saccess;
        }

        public bool saveVisa(Visa visa)
        {
            cmd = "UPDATE `pass`.`client` SET `visitdate` = @visitdate,`status` = @status,"
                +"`region` = @region,`title` = @title,`firstname` = @firstname,`lastname` = @lastname,"
                +"`dob` = @dob,`email` = @email,`password` = @password,`passport` = @passport,"
                +"`passportexpire` = @passportexpire,`clientticket` = @clientticket,`visatype` = @visatype,"
                +"`nationality` = @nationality,`purpose` = @purpose,`persons` = @persons,`kids` = @kids,"
                +"`payed` = @payed,`travellength` = @travellength,`nearestdate` = @nearestdate,`userid` = @userid "
                + " WHERE `idclient` = @idclient;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand = commandParam(myCommand, visa, true);           
            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                saccess = true;
            }
            catch (Exception)
            {
                //MessageBox.Show("Произошла ошибка соединения с БД.");
            }
            finally
            {
                myConnection.Close();
            }

            return saccess;
        }

        public Visa getVisa(string id)
        {
            cmd = "SELECT idclient, `status`,`region`,`title`,`firstname`,`lastname`,"
                + "`dob`,`email`,`password`,`passport`,`passportexpire`,`clientticket`,"
                +"`visatype`,`nationality`,`purpose`,`persons`,`kids`,`payed`,"
                + "`travellength`,`nearestdate`,visitdate"
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
                    visa.setId(dr.GetInt32(0).ToString());
                    visa.setstatus(dr.GetInt32(1).ToString());
                    visa.setregion(dr.GetInt32(2).ToString());
                    visa.settitle(dr.GetString(3));
                    visa.setfirstname(dr.GetString(4));
                    visa.setlastname(dr.GetString(5));

                    visa.setdob(dr.GetString(6));
                    visa.setemail(dr.GetString(7));
                    visa.setpassword(dr.GetString(8));
                    visa.setpassport(dr.GetString(9));
                    visa.setpassportexpire(dr.GetString(10));
                    visa.setclientticket(dr.GetString(11));

                    visa.setvisatype(dr.GetInt32(12).ToString());
                    visa.setnationality(dr.GetInt32(13).ToString());
                    visa.setpurpose(dr.GetInt32(14).ToString());
                    visa.setpersons(dr.GetInt32(15).ToString());
                    visa.setkids(dr.GetInt32(16).ToString());
                    visa.setpayed(dr.GetInt32(17).ToString());

                    visa.settravellength(dr.GetInt32(18).ToString());
                    visa.setnearestdate(dr.GetInt32(19).ToString());
                    visa.setvisitdate(dr.GetString(20));
                    //visa.setuserid(dr.GetInt16(21));
                    //visa = new Visa(dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(3), dr.GetInt32(1).ToString());
                    // дописать момент заполение полей в объекте
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Произошла ошибка соединения с БД.");
            }
            finally
            {
                myConnection.Close();
            }

            return visa;
        }
        public bool saveDate(string date,string id)
        {
            cmd = "UPDATE `pass`.`client` SET `visitdate` = @visitdate , status = 1 "
                + " WHERE `idclient` = @idclient;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@visitdate", date);
            myCommand.Parameters.AddWithValue("@idclient", id);

            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                saccess = true;
            }
            catch (Exception)
            {
                //MessageBox.Show("Произошла ошибка соединения с БД.");
            }
            finally
            {
                myConnection.Close();
            }

            return saccess;
        }

        private MySqlCommand commandParam(MySqlCommand myCommand, Visa visa, bool save)
        {
            if (save)
                myCommand.Parameters.AddWithValue("@idclient", visa.getId());
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
            
            return myCommand;
        }
    }
}