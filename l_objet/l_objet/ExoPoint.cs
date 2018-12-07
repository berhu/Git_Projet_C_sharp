using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_objet
{
    class AppPoint
    {
        static void Main(string[] args)
        {
            double moveX = 0;
            double moveY = 0;
            bool testSaisie = false;
            Point dot = new Point();
            Console.WriteLine(dot.Affichage());

            Console.WriteLine("Donner une valeur à l'abscisse : ");
            do
            {
                try
                {
                    moveX = double.Parse(Console.ReadLine());
                    testSaisie = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\nCeci n'est pas un nombre, veuillez recommencer la saisie.");
                }

            } while (!testSaisie);

            testSaisie = false;

            Console.WriteLine("Donner une valeur à l'ordonnée : ");
            do
            {
                try
                {
                    moveY = double.Parse(Console.ReadLine());
                    testSaisie = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\nCeci n'est pas un nombre, veuillez recommencer la saisie.");
                }

            } while (!testSaisie);


            dot.Deplacer(moveX, moveY);
            Console.WriteLine(dot.Affichage());

            Point symX = dot.SymX();
            Console.WriteLine(symX.Affichage());

            Point symY = dot.SymY();
            Console.WriteLine(symY.Affichage());

            Point symOrigine = dot.SymOrigine();
            Console.WriteLine(symOrigine.Affichage());

            dot.Permute();
            Console.WriteLine(dot.Affichage());

            Console.ReadKey();

        }
    }
}
