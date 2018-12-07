using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday ||
    DateTime.Now.DayOfWeek == DayOfWeek.Sunday ||
    (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9) ||
    (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 18))
            {
                // nous sommes le week-end
                Program.
                    
            }
            else
            {
                // nous sommes en semaine
                if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                {
                    // nous sommes dans la journée
                    AfficherBonjour();
                }
                else
                {
                    AfficherBonsoir();
                }
            }
        }
    }
}
