using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_du_0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int joueur, computer;
            bool nbtest=false, abandon=false;
            int nbmanches=0;
            int compteurJ=0, compteurC=0;

            Random rnd = new Random();
            

            do
            {
                computer = rnd.Next(0, 3);
                Console.WriteLine("Veuillez choisir un nombre entre 0 et 2 : ");
                nbtest = int.TryParse(Console.ReadLine(), out joueur);

                if (nbtest == true && joueur<3)
                {
                    nbmanches++;
                    if (joueur == computer)
                    {
                        Console.WriteLine("Personne ne marque de points !");
                    }
                    else if ((joueur + 1 == computer) || (joueur == computer + 2))
                    {
                        compteurJ++;
                        Console.WriteLine("Vous marquez un point !");
                    }
                    else if (joueur < 0)
                    {
                        abandon = true;
                        Console.WriteLine("Le joueur abandonne");
                    }
                    else
                    {
                        compteurC++;
                        Console.WriteLine("L'I.A. marque 1 point, votre mort est proche !");
                    }
                    Console.WriteLine("Manche {0:0}.Vous avez {1:0} point(s) et l'I.A. en a {2:0} point(s)", nbmanches, compteurJ, compteurC);
                    Console.WriteLine("----------------------------------------------------------------------------");
                }
                else if (nbtest == true && joueur > 2)
                {
                    Console.WriteLine("Erreur de saisie, veuillez entrer un nombre entre 0 et 2 !!!");
                }
              
                else
                {
                    Console.WriteLine("Vous êtes trop idiot pour jouer, veuillez reprendre vos études en primaire");
                }
            
            } while (compteurC < 10 && compteurJ < 10 && abandon == false);

            if (compteurC >= 10 || abandon == true)
            {
                Console.WriteLine("L'I.A. gagne, vous êtes mort !!!");

            }
            else
	        {
                Console.WriteLine("Vous gagnez, votre suprématie sur la machine est totale");
	        }
            Console.ReadKey();
        }
    }
}
