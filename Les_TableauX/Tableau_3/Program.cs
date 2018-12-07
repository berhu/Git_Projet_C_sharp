using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[26];
            string phrase = null;
            bool Test;
            char lettre;

            //do
            //{
                Console.WriteLine("Veuillez saisir un texte d'au moins 120 caractères : ");
                phrase = Console.ReadLine();
            //Test = char.TryParse(Console.ReadLine(), out lettre);

            //} while (Test == false && lettre < 12);
            
            /*{
                Console.WriteLine("Vous n'avez pas saisi le nombre de caractère recommandé !");
                phrase = Console.ReadLine();
            }*/
            phrase = phrase.ToUpper();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (char.IsLetter(phrase[i])) tableau[(char)(phrase[i]) - 65] += 1;
            }

            for (int j = 0; j < 26; j++)

                Console.WriteLine("La lettre '" + (char)(j + 65) + "' apparaît: " + tableau[j] + " fois");

            Console.ReadKey();

            /* int[] alphabet = new int[26];
             int[] compteur = new int[26];
             char lettre;
             string phrases;
             bool T = false;
             phrases = phrases.ToUpper();

             do
             {
                 Console.WriteLine("Veuillez saisir un texte d'au moins 120 caractères : ");
                 T = char.TryParse(Console.ReadLine(), out lettre);

             } while (T == false && lettre < 20);
             {
                 Console.WriteLine("Vous n'avez pas saisi le nombre de caractère recommandé !");
                 phrases = Console.ReadLine();
             }
             for (int i = 0; i < length; i++)
             {
                
             }
             Console.ReadKey();*/
        }
    }
}

