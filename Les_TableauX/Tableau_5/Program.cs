using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase;
            bool palindrome = true;


            do
            {
                Console.WriteLine("Ecrivez une phrase terminée par un point : ");
                phrase = Console.ReadLine();
            } while (phrase[phrase.Length - 1] != '.');

            phrase = phrase.ToUpper();
            phrase = phrase.Replace(" ", "");
            phrase = phrase.Substring(0, phrase.Length -1 );

            char[] phraseInv = new char[phrase.Length];

            for (int i = 0; i < phraseInv.Length; i++)
            {
                phraseInv[i] = phrase[phrase.Length - 1 - i];
            }
            foreach (char lettre in phraseInv)
            {
                Console.Write(lettre);
            }
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].CompareTo(phraseInv[i]) != 0)
                {
                    palindrome = false;
                }
            }
            if (!palindrome)
                {
                    Console.Write(" La phrase n'est pas un palindrome ");
                }
                else
                {
                    Console.Write(" La phrase est un palindrome ");
                }
            Console.ReadKey();
        }
    }
}
