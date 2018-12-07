using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[26];
            string phrase = null;
            


            Console.WriteLine("Veuillez saisir un texte d'au moins 20 caractères : ");
            phrase = Console.ReadLine();
            while (phrase.Length < 20)
            {
                Console.WriteLine("Veuillez saisir un texte d'au moins 20 caractères : ");
                phrase = Console.ReadLine();
            }

            phrase = phrase.ToUpper();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (char.IsLetter(phrase[i])) tableau[(char)phrase[i] - 65]++;
            }

            for (int j = 0; j < 26; j++)
            {
                Console.WriteLine("La lettre '" + (char)(j + 65) + "' apparaît: " + tableau[j] + " fois");
            }
            Console.ReadKey();
        }
    }
}
