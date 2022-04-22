using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class Artist: BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }

        public Artist(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

    }
}
