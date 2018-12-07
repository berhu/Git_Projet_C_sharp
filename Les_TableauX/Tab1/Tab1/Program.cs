using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tab1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string J1;
            char[] tableauJ1;
            char[] tableaucache;
            char lettre;
            int termine = 0;
            bool trouve = false;
            int coups = 6;

            // tour joueur 1
            Console.WriteLine("                                   JEU DU PENDU                                                ");
            Console.WriteLine("Veuillez saisir un mot de 5 caractères : ");
            J1 = Console.ReadLine();
            tableauJ1 = J1.ToCharArray();
            tableaucache = J1.ToCharArray();

            for (int i = 1; i < tableaucache.Length - 1; i++)
            {
                tableaucache[i] = '_';
            }

            Console.Clear();

            //tour joueur 2

            do
            {
                termine = 0;
                trouve = false;
                for (int i = 0; i < tableaucache.Length; i++)
                {
                    Console.Write(tableaucache[i] + " ");
                }
                Console.Write(" Veuillez saisir une lettre : ");
                lettre = char.Parse(Console.ReadLine());

                for (int i = 0; i < tableauJ1.Length; i++)
                {
                    if (lettre == tableauJ1[i])
                    {
                        tableaucache[i] = lettre;
                        trouve = true;
                    }
                }
                if (trouve)
                {
                    Console.WriteLine(" Bravo, allez, encore une !!! ");
                }

                //Console.Write(" apres boucle ");
                if (!trouve)
                {
                    coups--;
                    Console.WriteLine(" ____________________________________________");
                    Console.WriteLine(" Mauvaise lettre, il vous reste {0:#} coup(s) !!! ", coups);
                    Console.WriteLine(" ____________________________________________");
                }
                switch (coups)
                {
                    case 1:

                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   ");
                                      
                        break;
                
                    case 2:

                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   ");
                    
                        
                        break;
               
                    case 3:

                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("   //|  |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   ");
                        
                        break;
                
                    case 4:

                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("   //|\\|     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   ");
                        
                        break;
                
                    case 5:
                        
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("   //|\\|     ");
                            Console.WriteLine("     -  |     ");
                            Console.WriteLine("   //   |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   ");
                        
                        break;
                
                    case 6:
                        
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("   //|\\|     ");
                            Console.WriteLine("     -  |     ");
                            Console.WriteLine("   // \\|     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   ");
                       
                        break;
                
                    default:
                        if (termine)
                        {

                            Console.WriteLine("        |--|  ");
                            Console.WriteLine("           |  ");
                            Console.WriteLine("           |  ");
                            Console.WriteLine("   \\O//   |  ");
                            Console.WriteLine("     |     |  ");
                            Console.WriteLine("     -     |  ");
                            Console.WriteLine("   // \\------");
                        }

                    

                        break;
                }
                //Console.Write(" apres compteur ");
                for (int i = 0; i < tableauJ1.Length; i++)
                {
                    if (tableauJ1[i] == tableaucache[i])
                    {
                        termine++;
                    }
                }
            } while (coups > 0 && termine < tableauJ1.Length);

            if (coups <= 0)
            {
                Console.WriteLine("Vous êtes mort !!!");
            }
            else
            {
                Console.WriteLine("Bravo, vous avez été graciés !!!");
            }

                Console.WriteLine(J1);
            
           

            Console.ReadKey();
        }

    }
}

