﻿using System;
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

        public bool addUser(User user)
        {
            cmd = "INSERT INTO `users` (`username`,`password`,`idtype`,`status`,`email`) " 
                + " VALUES(@username,@password,@idtype,@status,@email);";

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@username", user.getUser());
            myCommand.Parameters.AddWithValue("@password", user.getPass());
            myCommand.Parameters.AddWithValue("@idtype", user.getType());
            myCommand.Parameters.AddWithValue("@status", 0);
            myCommand.Parameters.AddWithValue("@email", user.getEmail());

            bool saccess = false;
            try{
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                saccess = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, не всё поля заполнены.");
            }
            finally
            {
                myConnection.Close();
            }

            return saccess;
        }

        public bool saveUser(User user)
        {

            cmd = "UPDATE `users` "
                 + " SET `username` = @username,`idtype` = @idtype, "
                 + " `status` = @status"
                 + " WHERE `idusers` = @iduser;";


            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;
            myCommand.Parameters.Clear();

            //MessageBox.Show(user.ToString());
            myCommand.Parameters.AddWithValue("@username", user.getUser());
            //myCommand.Parameters.AddWithValue("@password", user.getPass());
            myCommand.Parameters.AddWithValue("@idtype", user.getType());
            myCommand.Parameters.AddWithValue("@status", user.getStatus());
            //myCommand.Parameters.AddWithValue("@email", user.getEmail());
            myCommand.Parameters.AddWithValue("@iduser", user.getId());

            bool saccess = false;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                saccess = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, не всё поля заполнены.");
            }
            finally
            {
                myConnection.Close();
            }

            return saccess;
        }

        public User getUser(string id)
        {
            cmd = "SELECT idusers,username, password,idtype,status,email "
                + " FROM users WHERE idusers = @idusers;";

            myConnection.ConnectionString = Param.getConnectionString();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = cmd;

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@idusers", id);

            User user = new User();
            try
            {
                myConnection.Open();
                dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    user.setId(dr.GetInt32(0).ToString());
                    user.setUser(dr.GetString(1));
                    user.setPass(dr.GetString(2));
                    user.setType(dr.GetInt32(3).ToString());
                    user.setStatus(dr.GetInt32(4).ToString());
                    user.setEmail(dr.GetString(5));
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

            return user;
        }
    }
}