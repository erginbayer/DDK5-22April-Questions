using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22April_Questions
{
    internal abstract class BaseModel
    {
        public int ID { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;

    }
}
