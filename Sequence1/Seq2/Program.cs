using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq2
{
    class Program
    {
        static void Main(string[] args)
        {
            double RayonR; // 0
            double aire; // 1
            double volume; //2

            Console.WriteLine("Quel est le rayon de la sphère?");
            Console.WriteLine("Entrez la valeur recherchée");

            RayonR = double.Parse(Console.ReadLine());
            aire = 4 * Math.PI * Math.Pow(RayonR,2);
            volume = (double)4/3 * Math.PI * Math.Pow(RayonR,3);

            Console.WriteLine("L'aire de la sphère de rayon R est de: {0:###.###} Km l'aire est de: {1:##,###.00} Km² et son volume est de: {2:#,###.###} Km³",RayonR,aire,volume);
            Console.ReadKey();
        }
    }
}
