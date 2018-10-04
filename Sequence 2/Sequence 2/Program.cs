using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A; //0
            double B; //1

            Console.WriteLine("Veuillez indiquer la valeur A");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez indiquer la valeur B");
            B = double.Parse(Console.ReadLine());

            if (B > A)
            {
                Console.WriteLine("L'ordre croissant correspond à : {0} et {1}", A, B);
            }
            else
            {
                Console.WriteLine("L'ordre croissant correspond à : {0} et {1}", B, A);
            }
            Console.ReadKey();

        }
    }
}
