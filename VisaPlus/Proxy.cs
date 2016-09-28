using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    class Proxy
    {
        private string proxyIP;
        private string proxyPort;

        public void setProxyIP(string proxyIP)
        {
            this.proxyIP = proxyIP;
        }

        public string getProxyIP()
        {
            return proxyIP;
        }

        public void setProxyPort(string proxyPort)
        {
            this.proxyPort = proxyPort;
        }

        public string getProxyPort()
        {
            return proxyPort;
        }
    }
}
