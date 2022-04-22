using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist artist = new Artist("Mehmet", "Bayer");
            artist.Country = "Türkiye";
            artist.Birthday = new DateTime(1999, 1, 12);

            User user = new User("Emre", "Ponçik");
            user.EMail = "deneme@gmail.com";
            user.Address = "Etiler";
            user.Password = "123";



            Console.Write(user.Password);
            Console.Read();
        }
    }
}
