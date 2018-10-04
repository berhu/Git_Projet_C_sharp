using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            do
            {

            bool test1;
            int nb,reste;
            int div=2;
            double carre;
            bool test=true;

                Console.Clear();
                do
                {
                    Console.Write("Veuillez saisir un nombre entier positif : ");
                    test1 = int.TryParse(Console.ReadLine(), out nb);
                    carre = Math.Sqrt(nb);

                } while (test1 == false);
                //Console.WriteLine("racine  = " + carre);
                if (nb == 2)
                {
                    test = true;
                }
                else
                    {
                    if (nb == 1)
                    {
                        test = false;
                    }
                    else
                    {
                        do
                        {
                            reste = nb % div;
                            //Console.WriteLine("reste = " + reste);
                            Console.WriteLine("div = " + div);
                            if (reste == 0)
                            {
                                test = false;
                            }
                            else
                            {
                                test = true;
                            }

                            div = div + 1;                                                                    
                        } while (test == true && div <= carre);
                    }
                }
                if (test == true)
                {
                    Console.WriteLine(nb + " est un nombre premier");
                }
                else
                {
                    Console.WriteLine(nb + " n'est pas un nombre premier");
                }
                    Console.ReadKey();
                    Console.WriteLine("Avez vous un autre nombre à rechercher ? o/n : ");
                    reponse = Console.ReadLine();

            } while (reponse == "o");

                    Console.WriteLine("Bonne journée, au revoir ! ");
                    Console.ReadKey();
            
		}
    }
}
