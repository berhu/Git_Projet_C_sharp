using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoint
{
    class AppPoint
    {
        static void Main(string[] args)
        {

            float movex = 0;
            float movey = 0;
            bool testSaisie = false;
            Point pixel = new Point();
            Console.WriteLine(pixel.Afficher());

            Console.WriteLine("Veuillez saisir un nombre correspondant à l'abscisse : ");
            do
            {
                try
                {
                    movex = float.Parse(Console.ReadLine());
                    testSaisie = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\nCeci n'est pas un nombre, veuillez recommencer la saisie.");
                }
            } while (!testSaisie);

            testSaisie = false;

            Console.WriteLine("Veuillez saisir un nombre correspondant à l'ordonnée : ");
            do
            {
                try
                {
                    movey = float.Parse(Console.ReadLine());
                    testSaisie = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\nCeci n'est pas un nombre, veuillez recommencer la saisie.");
                }

            } while (!testSaisie);



            pixel.Deplacer(movex, movey);
            Console.WriteLine(pixel.Afficher());

            Point symx = pixel.SymX();
            Console.WriteLine(symx.Afficher());

            Point symy = pixel.SymY();
            Console.WriteLine(symy.Afficher());

            Point symor = pixel.SymOr();
            Console.WriteLine(symor.Afficher());

            pixel.Permute();
            Console.WriteLine(pixel.Afficher());

            Console.ReadKey();
        }
    }
}
