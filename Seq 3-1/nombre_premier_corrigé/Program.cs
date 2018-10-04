using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre_premier_corrigé
{
    class Program
    {
        static void Main(string[] args)
        {
            //lire un nombre entier et déterminer si il est premier
            int a, reste, n=2;
            bool diviseur = false; bool test = false;

            do
            {
                Console.WriteLine("Valeur de a : ");
                test = int.TryParse(Console.ReadLine(), out a);

            } while (test == false);   //tant que test (la saisie) est fausse, on recommence la demande

            if (a>1)
            {
                do
                {                      //recherche du diviseur
                    reste = a % n;     //A reste n
                    if (reste == 0)
                    {
                        diviseur = true;
                        break;
                    }
                    n++;
                    
                } while (diviseur == false && n < a);

                if (diviseur == true)
                {
                    Console.WriteLine("Le nombre n'est pas premier, il a pour diviseur {0:##,###}",n);
                }
                else
	            {
                    Console.WriteLine("C'est un nombre premier !");
	            }
            }
            else
            {
                Console.WriteLine("Le nombre 1 n'est pas premier par définition");
            }
            Console.ReadKey();
        }
    }
}
