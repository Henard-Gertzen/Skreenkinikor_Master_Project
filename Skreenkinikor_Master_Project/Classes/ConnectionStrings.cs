using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Skreenkinikor_Master_Project.Classes
{
    public static class ConnectionStrings
    {//Con strings are in App.config
        public static readonly string conLoginStr = ConfigurationManager.ConnectionStrings["SkLogin"].ConnectionString;
        public static readonly string conSkreenMainStr = ConfigurationManager.ConnectionStrings["SkMain"].ConnectionString;
    }
}
