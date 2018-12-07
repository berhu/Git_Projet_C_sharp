using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFraction
{
    class Fraction
    {
        private int d;
        private int n;

        public int D { get { return d; } }

        public int N { get { return n; } }

        
        public Fraction(int _n = 0, int _d = 1)
        {
            n = _n;
            d = _d;
        }        
        public override string ToString()
        {
            string temp;
            if (d == 1)
            {
                temp = "" + n;
            }
            else
            {
                temp = n + "/" + d;
            }

            return temp;
        }
        public void Oppose()
        {
            n = -n;
        }
        public void Inverse()
        {
            int T;
            T = this.n;
            this.n = this.d;
            this.d = T;

        }
        public float Calculer()
        {
            return ((float)n / (float)d);
        }
        public bool Superieur(Fraction _f)
        {
            return (this.Calculer() > _f.Calculer());
        }
        public bool Inferieur(Fraction _f)
        {
            return (this.Calculer() < _f.Calculer());
        }
        public bool Egal(Fraction _f)
        {
            return (this.Calculer() == _f.Calculer());
        }
        public static void Affiche(Boolean f)
        {
            if (f == true)
            {
                Console.WriteLine("Vrai");
            }
            else
            {
                Console.WriteLine("Faux");
            }
        }
        //pgcd
        private int GetPgdc()
        {
            int a = this.n;

            int b = this.d;

            int pgcd = -1;

            if (a != 0 && b != 0)

            {

                if (a < 0) a = -a;

                if (b < 0) b = -b;

                while (a != b)

                    if (a < b)

                        b -= a;

                    else

                        a -= b;

                pgcd = a;
            }

            return pgcd;

        }
        public int Pgdc()
        {
            return GetPgdc();
        }
        private Fraction Reduire()
        {
            int R = GetPgdc();
            this.n = this.n / R;
            this.d = this.d / R;
            return new Fraction(this.n, this.d);
        }
        public Fraction Reduce()
        {
            return this.Reduire();
        }
        public Fraction Somme(Fraction _F)
        {
            Fraction somme = new Fraction(((this.n * _F.d) + (_F.n * this.d)), (this.d * _F.d));
            return somme;
        }
        public Fraction Soustraction(Fraction _F)
        {
            Fraction soustraction = new Fraction(((this.n * _F.d) - (_F.n * this.d)), (this.d * _F.d));
            return soustraction;
        }
        public Fraction Produit(Fraction _F)
        {
            Fraction produit = new Fraction((this.n *_F.n),(_F.d * this.d));
            return produit;
        }
        public Fraction Puissance(int _puissance)
        {
            return new Fraction((int)Math.Pow(n, _puissance), (int)Math.Pow(d, _puissance));
        }
    }
}
