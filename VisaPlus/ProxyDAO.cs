using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    interface ProxyDAO
    {
        void saveProxy(string ip, string port);
        void setProxy(string id);
        Proxy getProxy();
    }
}
