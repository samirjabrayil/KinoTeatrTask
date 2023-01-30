using KinoTeatrTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTeatrTask
{
    public  class Costomer : Entity
    {
        public Teatr VisiteTeatr { get; set; }
        public double Balance { get; set; } = 300;
        public Ticket[] Tickets { get; set; } = new Ticket[0];

        public Costomer(string name, double balance)
        {
            Balance = balance;
        }

    }
}
