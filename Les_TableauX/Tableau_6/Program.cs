using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_6
{
    class Program
    {
        public static bool Palindrome (string phrase)
        {
            //string phrase;

            Console.WriteLine("Veuillez saisir une phrase à tester");
            phrase = Console.ReadLine();

            for (int i = 0, j = phrase.Length - 1; i < j; i++, j--)
            {
                if (phrase[i] != phrase[j])
                {
                    return false;
                }
            }
            return true;
            
        }
        

    }
}
