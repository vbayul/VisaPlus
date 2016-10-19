using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    interface UserDAO
    {
        bool addUser(User user);

        bool saveUser(User user);

        User getUser(string id);

        void cleanUser();

        void updateTime(string id);

        bool isConnect(string id);
    }
}
