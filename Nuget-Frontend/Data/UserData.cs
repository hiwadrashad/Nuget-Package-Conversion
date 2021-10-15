using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuget_Library.Encryption;

namespace Nuget_Frontend.Data
{
    public class UserData
    {
        public static string username = "USERNAME";
        public static string password = "PASSWORD";
        public static string salt = "SALT";
        public static byte[] hash = SaltingAndHashing.GetHash(password,salt);
    }
}
