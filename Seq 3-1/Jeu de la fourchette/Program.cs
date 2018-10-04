using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_fourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            int random;
            int NbCoups = 0;
            int nb;
            int valeurmin=0;
            int valeurmax=100;

            
            Random rnd = new Random();
            random = rnd.Next(0, 101);

            //Console.WriteLine("le nombre créé est :" + random);
            //Console.ReadKey();
            do
            {
                Console.WriteLine("Devinez le nombre choisi entre : " + valeurmin+ " et " +valeurmax );
                nb = int.Parse(Console.ReadLine());     // nombre choisi par l utilisateur

                if (nb == random)
                {
                    Console.WriteLine("Bien joué !!!");
                }
                else
                {
                    if (nb < random)
                    {
                        valeurmin = nb;
                        Console.WriteLine("Raté, recommences !");
                    }

                    else
                    {
                        valeurmax = nb;
                        Console.WriteLine("Raté, recommences !");
                    }
                }
                NbCoups++;
            } while (nb != random);
            Console.WriteLine("Vous avez réussi en " + NbCoups + " coups");
            Console.ReadKey();

        }
    }
}
