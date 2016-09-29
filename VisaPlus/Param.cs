using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    static class Param
    {
        private static string userID;
        private static string connectionString;
        private static string access;

        public static string getUserID()
        {
            return userID;
        }
        public static void setUserID(string user)
        {
            userID = user;
        }
        public static string getConnectionString()
        {
            return connectionString;
        }
        public static void setConnectionString(string con)
        {
            connectionString = con;
        }
        public static string getAccess()
        {
            return access;
        }
        public static void setAccess(string acc)
        {
            access = acc;
        }

    }
}
