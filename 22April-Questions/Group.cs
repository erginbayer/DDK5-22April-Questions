using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class Group : BaseModel
    {
        public string Name { get; set; }
    
        public DateTime EstablishmentDate { get; set; }
        public List<Artist> Artists { get; set; }

        public Group(string name)
        {
            this.Name = name;
        }
    }
}
