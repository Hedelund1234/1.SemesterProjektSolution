using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.DataAccess
{
    internal class Class1
    {
        internal string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["default"].ToString();
        }
    }
}
