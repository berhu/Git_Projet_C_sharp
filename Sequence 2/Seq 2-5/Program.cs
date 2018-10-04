using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq_2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, x;

            Console.Write("Résolution de l'équation : ax+b=0");
            Console.ReadLine();

            Console.Write("Veuillez entrer la valeur de 'a' : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer la valeur de 'b' : ");
            b = double.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.Write("L'équation est indéterminée !");
                Console.ReadKey();
            }
            else if (a == 0 && b != 0)
            {
                Console.Write("L'équation est impossible !");
                Console.ReadKey();
            }
            else
            {
                x= -b/a;
                Console.Write("Valeur de x : {0:##,##0.00} ",x);
                Console.ReadKey();

            }
        }
    }
}
