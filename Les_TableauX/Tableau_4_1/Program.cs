using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int numcase;

            // saisie du nombre de case du tableau
            Console.Write("Nombre de cases : ");
            a = int.Parse(Console.ReadLine());

            //déclaration du tableau
            int[] tableau = new int[a];

            //saisie du tableau
            for (int i = 0; i < a; i++)
            {
                Console.Write(" Nombre n° " + i + " = ");
                tableau[i] = int.Parse(Console.ReadLine());
            }
            //premier affichage du tableau non trié
            for (int i = 0; i < a; i++)
            {
                Console.Write(tableau[i] + "  ");
            }

            //tri par sélection
            for (int j = 0; j < a - 1; j++)
            {
                //recherche de la position (de l'indice) du plus petit élément
                numcase = j;
                for (int k = j + 1; k < a; k++)
                {
                    if (tableau[k] < tableau[numcase])
                    {
                        numcase = k;
                    }
                }
                //échange des 2 cases (entre la plus petite et celle qui ce trouve à la position i)
                int temp = tableau[numcase];
                tableau[numcase] = tableau[j];
                tableau[j] = temp;

                //affichage du tableau en cours de tri
                Console.WriteLine();
                for (int k = 0; k < a; k++)
                {
                    Console.Write(tableau[k] + "  ");
                }

            }
            Console.ReadLine();
        }
    }
}
