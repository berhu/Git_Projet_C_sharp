using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            int[] tableau = new int[10];
            int saisi;
            bool test = true;

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = i + 1;
            }
            do
            {
                do
                {
                    Console.WriteLine("Veuillez saisir un nombre : ");
                    test = int.TryParse(Console.ReadLine(), out saisi);
                } while (test == false || saisi > 10);
                for (int i = 0; i < tableau.Length; i++)
                {
                    if (saisi == tableau[i])
                    {
                        Console.WriteLine("Le nombre " + saisi + " a été trouvé à l'indice " + i);
                        break;
                    }
                }
                Console.WriteLine("Souhaitez vous cherher un autre nombre? o/n : ");
                reponse = Console.ReadLine();
            } while (reponse == "o");
            Console.WriteLine("Bonne journée, au revoir ! ");
            Console.ReadKey();
        }
    }
}