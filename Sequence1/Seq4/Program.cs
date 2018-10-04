using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq4
{
    class Program
    {
        static void Main(string[] args)
        {
            double rayonR;
            double angleA;
            double aire;

            Console.Write("Veuillez saisir la valeur du Rayon R : ");
            rayonR = double.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir la valeur de l'angle A en degré(s) : ");
            angleA = double.Parse(Console.ReadLine());

            aire = Math.PI * Math.Pow(rayonR,2) * angleA / 360;

            Console.WriteLine("L'aire du secteur circulaire est de : {0:##.00} cm²",aire);
            Console.ReadKey();





        }
    }
}
