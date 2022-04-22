using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class MyFavorites :BaseModel
    {
        public List<Song> Songs { get; set; }
        public User User { get; set; }

    }
}
