using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ta
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenom;
            int sup = 6;
            int inf = 0;
            int milieuTab;
            int compare;

            string[] tableau = new string[7] { "agathe", "Berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };

            Console.WriteLine("Veuillez choisir un prénom dans la liste : ");
            prenom = Console.ReadLine();

            milieuTab = (inf + tableau.Length - 1) / 2;                                                     //recherche du milieu du tableau

            Console.WriteLine(" Le milieu du tableau est à l'indice : {0:0} ", milieuTab);                    //test de recherche
            Console.ReadKey();

            do
            {
                compare = prenom.CompareTo(tableau[milieuTab]);

                if (compare == -1)                             // nombre à gauche
                {
                    sup = milieuTab;
                    Console.WriteLine("Le nombre est entre "+ inf + " et "+ sup);

                    milieuTab = (inf + sup) / 2;

                    Console.WriteLine("(Le milieu du tableau est au numéro : " + milieuTab + ") ");
                    Console.ReadKey();
                }
                if (compare == 1)                               //nombre à droite
                {
                    inf = milieuTab;
                    Console.WriteLine("Le nombre est entre " + inf + " et " + sup);

                    milieuTab = ((inf + sup) / 2) + 1;
                    Console.WriteLine("(Le milieu du tableau est au numéro : " + milieuTab + ") ");
                    Console.ReadKey();
                }
                
            } while (compare != 0);
            Console.WriteLine("Le nom a été trouvé à l'indice {0:0} ", milieuTab);
            Console.ReadKey();
        }
    }
}
