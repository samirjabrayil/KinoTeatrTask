using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTeatrTask
{
    public class Ticket  
    {
        private static int _id = 1;
        public Ticket[] Tickets { get; set; }

        public override string ToString()
        {
            return $"{Tickets}";
        }
    }
}
