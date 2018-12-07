using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseArticle
{
    class Article
    {
        //attribut
        private int reference;
        private string designation;
        private double prixHT;
        private static double tauxTVA;      //attribut statique

        public int Reference
        {
            get {return reference;}
            set {reference = value;}
        }

        public string Designation
        {
            get{return designation;}
            set{designation = value;}
        }

        public double PrixHT
        {
            get{return prixHT;}
            set{prixHT = value;}
        }

        public static double TauxTVA        //propriété statique
        {
            get{return tauxTVA;}
            set{tauxTVA = value;}
        }

        public Article() { }                //constructeur par défaut

        public Article(int _ref, string _design, double _PrixHT)
        {
            reference = _ref;
            designation = _design;
            PrixHT = _PrixHT;
            
        }
        public Article(Article a)
        {
            reference = a.reference;
            designation = a.designation;
            PrixHT = a.PrixHT;
        }
        public double Calculer()
        {
            return PrixHT + (PrixHT * TauxTVA / 100);
        }
        public void AfficherArticle()
        {
            Console.WriteLine("Référence : " +reference);
            Console.WriteLine("Désignation : " + designation);
            Console.WriteLine("Prix Hors Taxe : " + prixHT);
        }
    }
}
