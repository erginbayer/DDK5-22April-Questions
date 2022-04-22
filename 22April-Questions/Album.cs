using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class Album :BaseModel
    {
        public string Ad { get; set; }
        public List<Song> Songs { get; set; }
        public int SongCount{ get => Songs.Count(); }
        public string CoverPhoto { get; set; }
        public Artist Artist { get; set; }

    }
}
