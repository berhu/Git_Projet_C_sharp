using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicules
{
    class Camion : Vehicule
    {
        public Camion(int modele, double prix) : base(modele, prix) { }

        public override void Demarrer()
        {
            Console.Out.WriteLine("Le camion démarre....");
        }

        public override void Accelerer()
        {
            Console.Out.WriteLine("Le camion Accélére....");
        }

        public override string ToString()
        {
            return "Camion_ " + base.ToString();
        }
    }
}
