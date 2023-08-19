using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skreenkinikor_Master_Project.Classes
{
    public static class UserSession
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string FullName { get; set; }

        public static void Initialize(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public static void logFullName(string fullName)
        {
            FullName = fullName;
        }
    }
}
