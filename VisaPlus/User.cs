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
        private string epass;
        private string status;

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }
        public void  setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return this.user;
        }
        public void setPass(string pass)
        {
            this.pass = pass;
        }
        public string getPass()
        {
            return this.pass;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return this.type;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setEPass(string epass)
        {
            this.epass = epass;
        }
        public string getEPass()
        {
            return this.epass;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public string getStatus()
        {
            return this.status;
        }

        public string ToString()
        {
            return id+" " +user+ " "+pass+" " +type+" "+status+ " " +email+ " " +epass;
        }
    }
}
