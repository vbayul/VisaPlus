using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace VisaPlus
{
    interface VisaDAO
    {
        bool  addVisa(Visa visa);
        bool saveVisa(Visa visa);
        Visa getVisa(string id);
        bool saveDate(string date, string id);
    }
}
