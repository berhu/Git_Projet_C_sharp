using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau__3
{
    class Program
    {
        public static bool Palindrome(string longueur)
        {

            int min = 0;
            int max = longueur.Length -1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = longueur[min];
                char b = longueur[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        static void Main()
        {
            string[] tableau =
        {
            "AA",
            "38783",
            "LAVAL",
            "LAVAL A ETE A LAVAL",
            "ET LA MARINE VA VENIR A MALTE",
            
        };

            foreach (string valeur in tableau)
            {
                Console.WriteLine("{0} = {1}", valeur, Palindrome(valeur));

            }
            Console.ReadKey();
        }
    }
}
