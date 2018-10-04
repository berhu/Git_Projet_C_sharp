using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double temp;
            bool testA;
            bool testB;

            do
            {
                Console.Write("Tapez la valeur A ici : ");
                testA = double.TryParse(Console.ReadLine(),out A);
            } while (testA == false);
            
            do
	        {
	         Console.Write("Tapez la valeur B ici : ");
            testB = double.TryParse(Console.ReadLine(),out B);
	        } while (testB == false);

            Console.WriteLine("La valeur de A est {0:n}",A);
            Console.WriteLine("La valeur de B est {0:n}", B);
            Console.ReadKey();

            Console.WriteLine("---------------Inversion de valeur---------------");
            temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Nouvelle valeur pour A : {0:n}",A);
            Console.WriteLine("Nouvelle valeur pour B : {0:n}",B);
            Console.ReadKey();

        }
    }
}
