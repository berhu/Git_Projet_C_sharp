using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq_2_3__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            bool anneeB;
            bool nouvelleannee = true;
            string reponse;

            do
            {
            
            Console.Write("Veuillez indiquer l'année recherchée : ");
            anneeB = int.TryParse(Console.ReadLine(), out A);

            if (anneeB == true)
            {
                if (A % 4 == 0 && A % 100 != 0 || A % 400 == 0)
                {
                    Console.WriteLine(A + " est une année bissextile !");
                }
                else
                {
                    Console.WriteLine(A + " n'est pas une année bissextile !");
                }
            }
            else
            {
                Console.WriteLine("Erreur de caractères, veuillez entrer une année !");
            }
                Console.WriteLine("Avez vous une autre année à rechercher ? o/n");
                reponse = Console.ReadLine();
                if (reponse == "n")
                {
                    nouvelleannee = false;
                }

            } while (nouvelleannee);
            Console.Write("Recherche terminée");
            Console.ReadKey();
        }
    }
}
