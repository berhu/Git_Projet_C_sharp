using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq_2___4
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            int x;

            Console.WriteLine("Entrez un nombre entier : ");
            x = int.Parse(Console.ReadLine());
            val = Math.Abs(x);

            Console.WriteLine("La Valeur absolue est : " + val );
            Console.ReadKey();

        }
    }
}
