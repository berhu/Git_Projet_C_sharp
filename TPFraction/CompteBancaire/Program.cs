using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque();
            b.Init();
            b.AjouteCompte("dutronc", 1245, -500, 4500);

            b.AfficherComptes();
            b.CompteSup();
            Compte c = b.RendCompte(1245);
            c.Afficher();

            

            if (b.Transfert(1245, 2568, 16000))   // 1000 euros du compte 1245 passe vers le compte 2568
             {
                    Console.WriteLine("Transfert effectué");
             }
            else
            {
                     Console.WriteLine("Transfert impossible, provision insuffisante sur le compte !");
            }


               



            ////création d'un compte de test au nom de Toto
            //Compte compteToto = new Compte("Toto ", 12345, 3000);

                            ////On définit le découvert autorisé à -500
                            //compteToto.DecouvertAutorise = -500;

                            ////Création d'un compte de test au nom de Titi
                            //Compte compteTiti = new Compte("Titi ", 45678, 0);


                            ////Affichage des informations des 2 comptes avant opérations
                            //Console.WriteLine(compteToto.Afficher());
                            //Console.WriteLine("\n" + compteTiti.Afficher());


                            ////On crédite le compte Toto (newCompte) de 2000€
                            //compteToto.Crediter(2000);
                            ////Affichage du compte Toto (newCompte) après l'opération de crédit
                            //Console.WriteLine(compteToto.Afficher());


                            ////On débite 500€ de compteToto (le débit devrait être accepté)
                            //compteToto.Debiter(500);
                            ////Affichage de compteToto après l'opération débit
                            //Console.WriteLine(compteToto.Afficher());

                            ////On débite 5300€ de compteToto (le débit devrait être refusé car il dépasse l'autorisation de découvert)
                            //compteToto.Debiter(5300);
                            ////Affichage de compteToto après l'opération débit
                            //Console.WriteLine(compteToto.Afficher());

                            ////Transfère de 1300€ vers compteTiti
                            //compteToto.Transferer(1300, compteTiti);

                            ////Affichage des informations des comptes après opérations
                            //Console.WriteLine("\nCompte Mr. Toto après le transfère vers le compte de Mr. Titi :");
                            //Console.WriteLine(compteToto.Afficher());
                            //Console.WriteLine("\nCompte Mr. Titi après le transfère depuis le compte de Mr. Toto :");
                            //Console.WriteLine(compteTiti.Afficher());

                            Console.ReadKey();
        }
    }
}
