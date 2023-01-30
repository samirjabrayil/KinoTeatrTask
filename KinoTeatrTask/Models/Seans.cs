using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTeatrTask.Models
{
    public class Seans
    {
        public Seans[] Seanses { get; set; } = new Seans[5];
        public int SeansTime { get; set; }
        public int SeansPrice { get; set; }

        public override string ToString()
        {
            return $"{Seanses[5]}{SeansTime}+\"n\"{SeansPrice}";
        }
    }
}
