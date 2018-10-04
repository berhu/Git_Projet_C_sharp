using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq_2___6
{
    class Program
    {
        static void Main(string[] args)
        {            
            int jour=0;
            int bi, mois = 0, annee = 0, valeurMois = 0, reste7, resultat4;
            string month = null;
            bool testannee, testjour, testmois;
            string reponse = null;

            do
            {
                Console.Clear();
                Console.WriteLine("..............................................................");
                Console.WriteLine("Déterminé le jour de la semaine pour une date de type jj/mm/aa");
                Console.WriteLine("..............................................................");

                do
                {
                    Console.Write("Veuillez saisir le jour : ");
                    //            jour = int.Parse(Console.ReadLine());
                    testjour = int.TryParse(Console.ReadLine(), out jour);
                } while (testjour == false);

                do
                {
                    Console.Write("Veuillez saisir le mois : ");
                    //            mois = int.Parse(Console.ReadLine());
                    testmois = int.TryParse(Console.ReadLine(), out mois);
                } while (testmois == false);

                do
                {
                    Console.Write("Veuillez saisir les deux derniers chiffres de l'année voulue : ");
                    //            annee = int.Parse(Console.ReadLine());
                    testannee = int.TryParse(Console.ReadLine(), out annee);
                } while (testannee == false);

                bi = annee % 4;
                resultat4 = annee / 4;

                switch (mois)
                {
                    case 1:                   //cas ou le mois est égale à 1 (janvier) 
                        if (bi == 0)
                        {
                            valeurMois = 0;   //Si la variable bi est égale à 0, l'année est bissextile

                        }
                        else
                        {
                            valeurMois = 1;   //Si la variable bi est différente de 0, l'année n'est pas bissextile
                        }
                        month = "janvier";
                        break;
                    case 2:                   //
                        if (bi == 0)
                        {
                            valeurMois = 3;
                        }
                        else
                        {
                            valeurMois = 4;
                        }
                        month = "février";
                        break;
                    case 3:
                        valeurMois = 4;
                        month = "mars";
                        break;
                    case 4:
                        valeurMois = 0;
                        month = "avril";
                        break;
                    case 5:
                        valeurMois = 2;
                        month = "mai";
                        break;
                    case 6:
                        valeurMois = 5;
                        month = "juin";
                        break;
                    case 7:
                        valeurMois = 0;
                        month = "juillet";
                        break;
                    case 8:
                        valeurMois = 3;
                        month = "août";
                        break;
                    case 9:
                        valeurMois = 6;
                        month = "septembre";
                        break;
                    case 10:
                        valeurMois = 1;
                        month = "octobre";
                        break;
                    case 11:
                        valeurMois = 4;
                        month = "novembre";
                        break;
                    case 12:
                        valeurMois = 6;
                        month = "décembre";
                        break;
                    default:
                        Console.Write("Le mois n'est pas compris entre 1 et 12, veuillez recommencer la saisie");
                        valeurMois = -1;
                        break;

                }
                if (valeurMois >= 0)
                {
                    reste7 = (annee + resultat4 + valeurMois + jour) % 7;
                }
                else
                {
                    reste7 = -1;
                }
                // Console.Write("Valeurmois:"+valeurMois);
               
                // Console.WriteLine("reste7 : " + reste7);
                switch (reste7)
                {
                    case 0:
                        Console.WriteLine("C'était le samedi " + jour + " " + month + " " + annee);
                        break;
                    case 1:
                        Console.WriteLine("C'était le dimanche " + jour + " " + month + " " + annee);
                        break;
                    case 2:
                        Console.WriteLine("C'était le lundi " + jour + " " + month + " " + annee);
                        break;
                    case 3:
                        Console.WriteLine("C'était le mardi " + jour + " " + month + " " + annee);
                        break;
                    case 4:
                        Console.WriteLine("C'était le mercredi " + jour + " " + month + " " + annee);
                        break;
                    case 5:
                        Console.WriteLine("C'était le jeudi " + jour + " " + month + " " + annee);
                        break;
                    case 6:
                        Console.WriteLine("C'était le vendredi " + jour + " " + month + " " + annee);
                        break;
                    default:
                        Console.Write("\t jour indéterminé, car saisie erronée");
                        break;
                }
                Console.ReadKey();


                Console.WriteLine("Avez vous une autre date à rechercher? o/n : ");
                reponse = Console.ReadLine();
            } while (reponse == "o");


            Console.WriteLine("Bonne journée, au revoir ! ");
            Console.ReadKey();
            
        }
    }
}
