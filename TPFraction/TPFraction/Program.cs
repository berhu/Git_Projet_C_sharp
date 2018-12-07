using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFraction
{
    class AppFraction
    {
        static void Main(string[] args)
        {

            Fraction f = new Fraction(12, 7);
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction(9);
            Fraction f3 = new Fraction(4, 7);
            Fraction f4 = new Fraction(120,-150);
            Fraction f5 = new Fraction(11, 7);
            Fraction f6 = new Fraction(5, 4);
            Fraction f7 = new Fraction(22, 14);
            Fraction f8 = new Fraction(-75, 90);
            //Exercices produit, somme, soustraction
            Fraction f9 = new Fraction(25, 11);
            Fraction f10 = new Fraction(5, 7);
            Fraction f11 = f10.Puissance(3);

            Ecran.Affiche(f);
            Ecran.Affiche(f1);
            Ecran.Affiche(f2);
            Console.WriteLine("Appuyez sur une touche pour continuer ...");
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            Console.WriteLine("Opposé du numérateur :");
            Ecran.Affiche(f3);
            f3.Oppose();
            Ecran.Affiche(f3);

            Console.WriteLine("Inversion de la fraction :");
            f3.Inverse();
            Ecran.Affiche(f3);

            Console.WriteLine("Opérateur supérieur ( > ) :");
            Console.WriteLine(f5.Superieur(f6));

            Console.WriteLine("Opérateur inférieur ( < ) :");
            Console.WriteLine(f5.Inferieur(f6));

            Console.WriteLine("Opérateur d'égalité ( = ) :");
            Console.WriteLine(f5.Egal(f7));

            Console.WriteLine("Recherche du Plus Grand Dénominateur Commun (PGDC) :");
            Console.WriteLine(f8.Pgdc());

            Console.WriteLine("Réduction et signe de la fraction :");
            Ecran.Affiche(f4.Reduce());


            Console.WriteLine("Somme des deux fractions :");
            Console.WriteLine(f9.Somme(f10));

            Console.WriteLine("Soustraction des deux fractions :");
            Console.WriteLine(f9.Soustraction(f10));

            Console.WriteLine("Produit des deux fractions :");
            Console.WriteLine(f9.Produit(f10));

            Console.WriteLine("Puissance");
            Ecran.Affiche(f10);

            Console.ReadKey();
        }
    }
}
