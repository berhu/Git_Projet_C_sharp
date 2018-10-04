using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq5
{
    class Program
    {
        static void Main(string[] args)
        {
            double S; //    somme initiale placée
            double i; //    Taux d'intérêts annuel en %
            double n; //    Nombre d'années 
            double V1; //   
            double V2;
            double gain;
            int réponse;

            Console.Write("Veuillez indiquer la somme initiale placée sur le compte : ");
            S = double.Parse(Console.ReadLine());

            Console.Write("Veuillez indiquer le taux d'intérêt : ");
            i = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Veuillez indiquer le nombre d'années de placement : ");
            n = double.Parse(Console.ReadLine());

            V1 = S * (1 + n * i);
            V2 = S * Math.Pow((1 + i), n);

            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("La valeur acquise est de {0:##,###.00} euros après {1:##} an(s)", V1, n);
            Console.WriteLine("La valeur acquise composée est de {0:##,###.00} euros après {1:##} an(s)", V2, n);

            Console.ReadKey();

        }
    }
}
