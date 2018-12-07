using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s,t;
            int[] tableau = new int[5];
            bool fin = false;


            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Veuillez saisir 5 chiffres : ");
                s = int.Parse(Console.ReadLine());
                tableau[i] = s;
            }

            do
	            {
	                if (tableau[0] > tableau[1])
                    {
                        t = tableau[0];
                        tableau[0] = tableau[1];
                        tableau[1] = t;
                    }
                    else if (tableau[1] > tableau [2])
                    {
                        t = tableau[1];
                        tableau[1] = tableau[2];
                        tableau[2] = t;
                    }
                    else if (tableau[2] > tableau [3])
                    {
                        t = tableau[2];
                        tableau[2] = tableau[3];
                        tableau[3] = t;
                    }
                    else if (tableau[3] > tableau[4])
                    {
                        t = tableau[3];
                        tableau[3] = tableau[4];
                        tableau[4] = t;
                    }
                    else
                    {
                        fin = true;
                    }
	            } while (!fin);

            foreach (int a in tableau)
            {
                Console.WriteLine("Chiffres après rangement {0:0}", a);
            }

             Console.ReadKey();
                
        }
    }
}
