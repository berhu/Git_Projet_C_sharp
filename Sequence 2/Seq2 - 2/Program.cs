using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq2___2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;

            Console.Write("Veuillez indiquer la valeur A : ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Veuillez indiquer la valeur B : ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Veuillez indiquer la valeur C : ");
            C = double.Parse(Console.ReadLine());

            if (A<B && B<C)
            {
                Console.WriteLine("L'ordre croissant est {0:##.####} suivi de {1:##.####} et de {2:##.####}",A,B,C); 
            }
            else if (A<C && C<B)
            {
                Console.WriteLine("L'ordre croissant est {0:##.####} suivi de {1:##.####} et de {2:##.####}",A,C,B);
            }
            else if (B<A && A<C)
            {
                Console.WriteLine("L'ordre croissant est {0:##.####} suivi de {1:##.####} et de {2:##.####}",B,A,C);
            }
            else if (B<C && C<A)
            {
                Console.WriteLine("L'ordre croissant est {0:##.####} suivi de {1:##.####} et de {2:##.####}",B,C,A);
            }
            else if (C<A && A<B)
            {
                Console.WriteLine("L'ordre croissant est {0:##.####} suivi de {1:##.####} et de {2:##.####}",C,A,B);
            }
            else if (C<B && B<A)
            {
                Console.WriteLine("L'ordre croissant est {0:##.####} suivi de {1:##.####} et de {2:##.####}",C,B,A);
            }
            else
            {
                Console.WriteLine("Des valeurs sont identiques, veuillez recommencer et changer les valeurs ! ");
            }
            Console.ReadKey();
        }
    }
}
