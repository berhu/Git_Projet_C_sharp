using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbP=0, age;
            int compt1 = 0, compt2;
            // 45, 35, 65, 76, 34, 20, 20, 30, 30, 30, 20, 20, 30, 20 ,30, 20, 20, 8, 15, 23

            Console.WriteLine("...............................................");
            Console.WriteLine("Compter le nombre de jeunes de moins de 20 ans");
            Console.WriteLine("...............................................");
            do
            {
                Console.WriteLine("Saisissez votre age : ");
                age = int.Parse(Console.ReadLine());

                if (age < 20)
                {
                     compt1++;
                }
                     nbP++;

            } while (nbP < 20);

            if (compt1 == 20)
                {
                    Console.WriteLine(" TOUTES LES PERSONNES ONT MOINS DE 20 ANS ");
                    Console.ReadKey();
                }
            else
            {
                if (compt1 == 0)
                {
                    Console.WriteLine(" TOUTES LES PERSONNES ONT PLUS DE 20 ANS ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Le nombre de personnes dont l'âge est strictement inférieur à 20 ans est de " + compt1);
                    Console.ReadKey();
                }
                    
            }
            
        }
    }
}
