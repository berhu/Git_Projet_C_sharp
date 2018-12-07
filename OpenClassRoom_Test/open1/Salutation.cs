using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime1
{
    public static class Salutation
    {
        public static void AfficherBonjour()
        {
            Console.WriteLine("Bonjour " + Environment.UserName);
        }
        public static void AfficherBonsoir()
        {
            Console.WriteLine("Bonsoir " + Environment.UserName);
        }
    }
}
