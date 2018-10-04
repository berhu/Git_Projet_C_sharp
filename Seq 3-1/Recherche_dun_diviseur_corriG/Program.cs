using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recherche_dun_diviseur_corriG
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 2, res;
            bool test = false, premier = true;

            do
            {
                Console.WriteLine("Choisissez un nombre!");
                test = int.TryParse(Console.ReadLine(), out n);
                if (n < 2)
                {
                    test = false;
                }
            } while (i < n);
            {
                res = n % i;
                if (res == 0)
                {
                    Console.WriteLine("Le nombre saisi {0:##,###} a pour diviseur {1}", n, i);
                    premier = false;
                }
                i++;
            }
            if (premier == true)
            {
                Console.WriteLine("Le nombre premier n'a pas de diviseur autre que 1 et lui-même !");
            }
            Console.ReadKey();
        }
    }
}
