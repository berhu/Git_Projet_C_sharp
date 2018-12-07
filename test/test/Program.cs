using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = null;
            string[,] tabLogins = new string[3, 3]; //{{"user","","2"},{"adelon","leclandessiciliens","1"},{"jbelmondo","leprofessionnel","1"}};
            string motDePasse = null;
            bool MDPValide = false;

            tabLogins[0, 0] = "user";                   //nom
            tabLogins[0, 1] = "";                       //mot de passe

            tabLogins[1, 0] = "adelon";                 //nom
            tabLogins[1, 1] = "leclandessiciliens";     //mot de passe

            tabLogins[2, 0] = "jbelmondo";              //nom
            tabLogins[2, 1] = "leprofessionnel";        //mot de passe

            //demande à l'utilisateur d'entrer un login et mot de passe
            Console.WriteLine("Entrez votre login svp :");
            login = Console.ReadLine();

            Console.WriteLine("Entrez votre mot de passe svp  :");
            motDePasse = Console.ReadLine();

            // Vérification du couple login et mot de passe
            for (int i = 0; i < tabLogins.GetLength(0); i++)
            {
                if (tabLogins[i, 0] == login && tabLogins[i, 1] == motDePasse)
                {
                    MDPValide = true;
                }
            }
            // Informer l’utilisateur sur l’état de la connexion
            if (MDPValide == true)
            {
                Console.WriteLine("La connexion est réussie");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");  
            }
            Console.ReadKey();
        }
    }
}
