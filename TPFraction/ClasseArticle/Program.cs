using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            string d;
            double p;

            Console.Write("Veuillez donner le taux de la TVA pour tous les articles : ");
            Article.TauxTVA = double.Parse(Console.ReadLine());
            Console.WriteLine("Le taux de TVA est de " + Article.TauxTVA + "%");

            Console.WriteLine("\nArticle 1 : ");
            Article Art1 = new Article();
            Art1.AfficherArticle();
            Console.WriteLine("Le prix TTC de l'article est de " + Art1.Calculer() + " € ");

            Console.WriteLine("\nArticle 2 : ");
            Console.WriteLine("Saisissez la référence du produit : ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la désignation du produit : ");
            d = Console.ReadLine();
            Console.WriteLine("Saisissez le prix du produit : ");
            p = double.Parse(Console.ReadLine());
            Article Art2 = new Article(r, d, p);
            Art2.AfficherArticle();
            Console.WriteLine("Le prix de l'article " + d + " est de " + Art2.Calculer() + "€");















            Console.ReadKey();
        }
    }
}
