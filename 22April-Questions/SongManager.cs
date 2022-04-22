using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal class SongManager :BaseModel
    {
        public string CalculatePlayDate(IPieceEntity pieceEntity)
        {
            var playDate = pieceEntity.LastPlayDate.ToString("dd MMMM yyyy, dddd");
            return playDate;
        }
        public void PlaySong(ICall iCall)
        {
            Console.WriteLine("Playing : " + ((Song)iCall).Name);
            iCall.Call((Song)iCall);
        }

    }
}
