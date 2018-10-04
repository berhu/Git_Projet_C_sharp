using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recherche_des_Diviseurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            do
            {
                int nb, reste;
                int div = 2;
                bool test = true;
                bool premier = true;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Recherche des diviseurs d'un nombre");
                    Console.Write("Veuillez saisir un nombre entier positif : ");
                    test = int.TryParse(Console.ReadLine(), out nb);
                } while (test == false);

                do
                {
                    reste = nb % div;
                    if (reste == 0)
                    {
                        Console.WriteLine(div + " est un diviseur de " + nb);
                        premier = false;
                    }
                    
                    div++;
                } while (div < nb);


                if (premier == true)
                {
                    Console.WriteLine(nb + " n'a pas de diviseurs"); 
                }
                Console.WriteLine("Avez vous un autre nombre à rechercher ? o/n : ");
                reponse = Console.ReadLine();

            } while (reponse == "o");

            Console.WriteLine("Bonne journée, au revoir ! ");
            Console.ReadKey();

        }
    }
}
