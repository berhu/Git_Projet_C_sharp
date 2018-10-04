using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nombreA;
            float nombreB;
            float moyenne;

            Console.Write("Veuillez saisir le nombre décimal ou non pour A :");
            nombreA = float.Parse(Console.ReadLine());

            Console.Write("Veuillez saisir le nombre décimal ou non pour B :");
            nombreB = float.Parse(Console.ReadLine());

            moyenne = (nombreA + nombreB) / 2;

            Console.WriteLine("La moyenne des deux nombres est : {0:##.00}",moyenne);
            Console.ReadKey();

        }
    }
}
