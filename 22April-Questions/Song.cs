using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class Song:BaseModel,IPieceEntity,ICall
    {
        public string Name { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public DateTime ReleaseDate { get => AnnouncementDate.AddDays(10); }
        public int Duration { get; set; }
        public Artist Artist { get; set; }
        public DateTime LastPlayDate { get; set; }

        public Song(string name)
        {
            this.Name = name;
        }

        public void Call(Song song) { }
    }
}
