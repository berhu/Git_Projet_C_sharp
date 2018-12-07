using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire_CorrigeFranck
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte(12345, "Tournesol", 2000.50F, -1000);
            Compte compte2 = new Compte(56789, "Tintin", 5600, -1500);

            compte1.Afficher();
            compte2.Afficher();



        }
    }
}
