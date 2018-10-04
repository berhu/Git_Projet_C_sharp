using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnabé_fait_ses_courses
{
    class Program
    {

        /// <summary>
        /// Point d'entrée du programme
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double S, depense,reste;
            int comptMag = 0;
            bool testS = false;


            Console.WriteLine("Combien de francs possède Barnabé : ");

            do
            {
                testS = double.TryParse(Console.ReadLine(), out S);

                if (S < 0)
                {
                    Console.WriteLine(" Veuillez entrer un nombre positif. ");
                }
                else if (testS == false)
                {
                    Console.WriteLine(" Erreur de saisie : veuillez entrer un nombre positif et non une lettre! ");
                }

            } while (testS == false || S < 0);

            //

            do
            {
                if (S > 2)
                {
                    comptMag++;
                    depense = S;
                    S = S-(S / 2) - 1;
                    depense = depense - S ;
                    
                    Console.WriteLine("Barnabé à dépensé {0:##,###.##} francs dans le magasin n° {1:##,###}, il lui reste {2:##,###.##} francs",depense,comptMag,S);
                }
                else
                {
                    reste = S;
                    S = S - S;
                    comptMag++;
                    Console.WriteLine("Barnabé à dépensé {0:##,###.##} francs dans le magasin n° {1:##,###.##}, il lui reste {2:##,##0.##} francs",reste ,comptMag,S);
                    
                }
            } while (S != 0);

            Console.WriteLine("...............................................");
            Console.WriteLine("Barnabé a fait ses courses dans {0} de magasins",comptMag);
            Console.WriteLine("...............................................");
            Console.ReadKey();

        }
    }
}
