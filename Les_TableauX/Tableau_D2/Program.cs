using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_D2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool formatage = false;

            do
            {
                Console.WriteLine("Veuillez choisir le nombre de formations");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    formatage = true;

                }
                catch (Exception)
                {
                    
                    throw;
                }
            } while (!formatage);
        }
    }
}
