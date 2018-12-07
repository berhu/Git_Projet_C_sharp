using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce2
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("Fait-il beau? o/n");
            reponse = Console.ReadLine();
            if (reponse=="n")
            {
                Console.WriteLine("Je passe la journée à lire");
                Console.WriteLine("Est-ce que j'ai Madame Bovary dans ma bibliothèque? o/n");
                reponse = Console.ReadLine();
                if (reponse=="n")
                {
                    Console.WriteLine("Alors je vais à la bibliothèque municipale");
                    Console.WriteLine("Madame Bovary est-il disponible à la bibliothèque municipale? o/n");
                    reponse=Console.ReadLine();
                    if (reponse=="n")
                    {
                        Console.WriteLine("Alors, j'emprunte un livre policier et je m'installe dans un fauteuil à la maison.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Je rentre à la maison et je m'installe dans un fauteuil pour lire.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Alors je m'installe dans un fauteuil et je lis!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Mon vélo est il en bon état? o/n");
                reponse = Console.ReadLine();
                if (reponse == "n")
                {
                    Console.WriteLine("Alors je vais voir le garagiste.");
                    Console.WriteLine("Réparation immédiate? o/n");
                    reponse = Console.ReadLine();
                    if (reponse=="n")
                    {
                        Console.WriteLine("Alors, je vais à pied jusqu'à l'étang.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Alors, je vais faire une balade à vélo.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Alors, j'irai faire une balade à vélo.");
                    Console.ReadKey();
                }
            }
        }
    }
}
