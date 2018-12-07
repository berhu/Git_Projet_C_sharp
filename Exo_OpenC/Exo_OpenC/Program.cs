using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_OpenC
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] tabLot;
            Random alea;
            string saisie;

            Console.WriteLine("Appuyez sur 'Entrée' pour lancer le programme !");
            
            do        // Tant que la saisie est différent de "q", on boucle. 
                                                                
            {
                saisie = Console.ReadLine();

                tabLot = new int[7];                            //Construction du tableau de 7 éléments

                alea = new Random();                            //Générateur de nombre aléatoire

                tabLot[0] = alea.Next(1, 50);
                tabLot[1] = alea.Next(1, 50);
                tabLot[2] = alea.Next(1, 50);
                tabLot[3] = alea.Next(1, 50);
                tabLot[4] = alea.Next(1, 50);
                tabLot[5] = alea.Next(1, 50);
                tabLot[6] = alea.Next(1, 50);

                for (int i = 0; i < tabLot.Length; i++)         //Parcours du tableau afin de vérifier chaque indice
                {
                    for (int j = 0; j < tabLot.Length; j++)     //Pour chaque entrée, je reparcours le tableau
                    {
                        if (j != i)
                        {
                            if (tabLot[i] == tabLot[j])         //Si l'indice de tableau[i] correspond à l'indice de l'indice [j], on relance un numéro aléatoire
                            {
                                tabLot[j] = alea.Next(1, 50);
                            }
                        }
                    }
                    Console.WriteLine(tabLot[i]);               //On affiche le tableau
                }

                Console.WriteLine("Saisissez 'q + entrée' pour quitter, ou 'entrée' pour relancer");
            }
            while (saisie != "q");

            Console.ReadKey();
        }
    }
}
