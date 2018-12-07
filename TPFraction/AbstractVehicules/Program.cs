using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture car = new Voiture(1996, 3500);
            Console.WriteLine(car);
            car.Demarrer();
            car.Accelerer();

            Camion c = new Camion(2003, 4560000);
            Console.Out.WriteLine(c);
            c.Demarrer();
            c.Accelerer();

            Console.ReadKey();
        }
    }
}
