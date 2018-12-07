using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesBoucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            foreach (string parametre in args)
            {
                Console.WriteLine(parametre);
            }

            int valeurATrouver = new Random().Next(0, 100);
            int nombredecoups = 1;
            bool trouve = false;

            Console.WriteLine(valeurATrouver);

            Console.WriteLine("Veuillez saisir un nombre entre 0 et 99 (inclu)");

            while (!trouve)
            {
                string saisie = Console.ReadLine();

                if (int.TryParse(saisie, out int valeurSaisie))
                {
                    if (valeurSaisie == valeurATrouver)
                    {
                        trouve = true;
                    }
                    else
                    {
                        if (valeurSaisie < valeurATrouver)
                        {
                            Console.WriteLine("Trop petit ...");
                        }
                        else
                        {
                            Console.WriteLine("Trop grand ...");
                        }
                        nombredecoups++;
                    }
                }
                else
                {
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                }
            }
            Console.WriteLine("Vous avez trouvé en " + nombredecoups + " coups");
            Console.ReadKey();
        }
    }
}
