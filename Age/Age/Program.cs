using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime aujourd = DateTime.Now;
            int jour = 1, mois = 1, annee = 1;
            DateTime dateMajeur = new DateTime(aujourd.Year - 18, aujourd.Month, aujourd.Day);
            //TimeSpan temppasse;
            bool tparse = false;
            //bool testSaisie = false;


            Console.WriteLine(aujourd);
            Console.WriteLine("Veuillez saisir votre date de naissance format 'jj/mm/aaaa' : ");

            Console.WriteLine("Veuillez saisir le jour de la semaine : ");
            tparse = int.TryParse(Console.ReadLine(), out jour);

            Console.WriteLine("Veuillez saisir le mois : ");
            tparse = int.TryParse(Console.ReadLine(), out mois);

            Console.WriteLine("Veuillez saisir l'année : ");
            tparse = int.TryParse(Console.ReadLine(), out annee);

            //DateTime dateNaissance = new DateTime(annee, mois, jour);
            //temppasse = dateNaissance - aujourd;
            //Console.WriteLine("Nombre de millisecondes: {0:##} ", temppasse.TotalMilliseconds);
            //int age = Math.Abs(temppasse.Days);
            //Console.WriteLine(age);
            //int année = age / 365;
            //Console.WriteLine("Vous avez {0} ans ! ", année);

            DateTime jouranniversaire = new DateTime(annee, mois, jour);

            if (jouranniversaire <= dateMajeur)
            {
                Console.WriteLine("Vous êtes majeur ! ");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur ! ");
            }

            Console.ReadKey();
        }
    }
}


