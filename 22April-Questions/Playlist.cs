using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class Playlist :BaseModel, IPieceEntity
    {
        public List<Song> Song { get; set; }
        public User User { get; set; }
        public int SongCount { get => Song.Count(); }
        public DateTime LastPlayDate { get; set; }
    }
}
