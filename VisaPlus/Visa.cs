using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    class Visa
    {
        private string idclient;
        private string clientName;
        private string clientTicket;
        private string clientStatus;

        public Visa(string clientName,  string clientTicket, string clientStatus)
        {
            this.clientName = clientName;
            this.clientTicket = clientTicket;
            this.clientStatus = clientStatus;
        }
        public Visa(string idclient, string clientName, string clientTicket, string clientStatus)
        {
            this.clientStatus = clientStatus;
            this.clientName = clientName;
            this.clientTicket = clientTicket;
            this.idclient = idclient;
        }

        public Visa()
        {

        }

        public string getClientName()
        {
            return clientName;
        }

        public string getClientTicket()
        {
            return clientTicket;
        }

        public string getClientStatus()
        {
            return clientStatus;
        }

        public string getClientId()
        {
            return idclient;
        }
    }
}
