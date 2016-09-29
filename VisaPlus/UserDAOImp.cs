using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VisaPlus
{
    class UserDAOImp : UserDAO
    {
        private string cmd = "";
        private MySqlConnection myConnection = new MySqlConnection(Param.getConnectionString());
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataReader dr;
        private MySqlDataAdapter da;
        private DataSet ds;

        public void addUser(User user)
        {
            cmd = "INSERT INTO `pass`.`users` (`username`,`password`,`idtype`,`status`,`email`,`emailpass`) " 
                + " VALUES(@username,@password,@idtype,@status,@email,@emailpass);";

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@username", user.getUser());
            myCommand.Parameters.AddWithValue("@password", user.getPass());
            myCommand.Parameters.AddWithValue("@idtype", user.getType());
            myCommand.Parameters.AddWithValue("@status", 0);
            myCommand.Parameters.AddWithValue("@email", user.getEmail());
            myCommand.Parameters.AddWithValue("@emailpass", user.getEPass());
            
            try{
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка cоединения с БД.");
            }
        }

        public void saveUser(User user)
        {
            cmd = "UPDATE `pass`.`users` "
                 +" SET `username` = username,`idtype` = idtype, password = @password,"
                 + " `status` = status, `email` = email,`emailpass` = emailpass "
                 + " WHERE `idusers` = @iduser;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@username", user.getUser());
            myCommand.Parameters.AddWithValue("@password", user.getPass());
            myCommand.Parameters.AddWithValue("@idtype", user.getType());
            myCommand.Parameters.AddWithValue("@status", user.getStatus());
            myCommand.Parameters.AddWithValue("@email", user.getEmail());
            myCommand.Parameters.AddWithValue("@emailpass", user.getEPass());
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка cоединения с БД.");
            }
        }

        public User getUser(string id)
        {
            User user = new User();
            return user;
        }
        public void setPass(string id, string pass)
        {
            cmd = "UPDATE `pass`.`users` SET "
                + " `password` = @passworde "
                + " WHERE `idusers` = @iduser;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@password", pass);
            myCommand.Parameters.AddWithValue("@iduser", id);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка cоединения с БД.");
            }
        }
    }
}
