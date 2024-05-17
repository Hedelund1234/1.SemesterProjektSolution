using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.DataAccess
{
    internal class ConnectionHandler
    {
        internal string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Hjalte"].ToString();
        }
    }
}
