using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq3
{
    class Program
    {
        static void Main(string[] args)
        {
            double côtéA;
            double côtéB;
            double côtéC;
            double p;      // 0
            double aire;   // 1


            Console.Write("Veuillez saisir la longueur du côté A : ");
            côtéA = double.Parse(Console.ReadLine());

            Console.Write("Veuillez saisir la longueur du côté B : ");
            côtéB = double.Parse(Console.ReadLine());

            Console.Write("Veuillez saisir la longueur du côté C : ");
            côtéC = double.Parse(Console.ReadLine());

            p = côtéA + côtéB + côtéC;
            aire = Math.Sqrt(p/2 * (p/2-côtéA)*(p/2-côtéB)*(p/2-côtéC));

            Console.WriteLine("Le périmètre du triangle est de {0:##0.00} cm et l'aire du triangle est de {1:###.00} cm²", p, aire);
            Console.ReadKey();

        }
    }
}
