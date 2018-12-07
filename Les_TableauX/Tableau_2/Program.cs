using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine, point = ".";
            int comptLettres = 0;
            char maLettre;
            bool T = false;

            Console.WriteLine("Veuillez saisir une phrase : ");
            chaine = Console.ReadLine();

            while (chaine == point)
            {
                Console.WriteLine("LA CHAINE EST VIDE");
                Console.WriteLine("Veuillez saisir une phrase : ");
                chaine = Console.ReadLine();
            }
            Console.WriteLine("Veuillez saisir la lettre recherchée : ");
            T = char.TryParse(Console.ReadLine(), out maLettre);

            foreach (char L in chaine)
            {
                if (L == maLettre)
                {
                    comptLettres++;
                }
            }
            if (comptLettres > 0)
            {
                Console.WriteLine("La lettre " + maLettre + " est présente : {0:##} fois", comptLettres);
            }
            else
            {
                Console.WriteLine("La lettre n'est pas présente dans la phrase");
            }
            Console.ReadKey();
        }
    }
}
