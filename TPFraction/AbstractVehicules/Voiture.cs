using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicules
{
    class Voiture : Vehicule
    {
        public Voiture(int _AnneeModele, double _Prix) : base(_AnneeModele, _Prix)
        {

        }
        public override void Demarrer()
        {
            Console.WriteLine("La voiture démarre ....");
        }
        public override void Accelerer()
        {
            Console.WriteLine("La voiture accélère ...");
        }
        public override string ToString()
        {
            return "Voiture_ " + base.ToString();
        }
    }
}
