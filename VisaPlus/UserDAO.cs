using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    interface UserDAO
    {
        void addUser(User user);

        void saveUser(User user);

        User getUser();

        void setUser();
    }
}
