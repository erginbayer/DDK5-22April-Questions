using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class User :BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Password { get => MD5Create(Password); set => Password = value; }

        public User(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public static string MD5Create(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }

    }
}
