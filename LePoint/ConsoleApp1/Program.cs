using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("A");
                int value = int.Parse("8A");
                Console.Write("B");
            }
            catch (FormatException)
            {
                Console.Write("C");
                return;
            }
            finally
            {
                Console.Write("D");
            }
            Console.Write("E");
            Console.ReadKey();
        }
    }
}
