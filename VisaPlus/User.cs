using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    class User
    {
        private string id;
        private string user;
        private string pass;
        private string type;
        private string email;

        public void  setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return user;
        }
        public void setPass(string pass)
        {
            this.pass = pass;
        }
        public string getPass()
        {
            return pass;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return type;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
    }
}
