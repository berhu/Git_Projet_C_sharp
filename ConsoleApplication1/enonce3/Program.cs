using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce3
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            bool restelivre = true;
            
           
         do{
             Console.WriteLine("Il reste au moins un livre dans la bibliothèque à trier");
            Console.WriteLine("Est-ce que c'est un livre scolaire? o/n");
            reponse = Console.ReadLine();
            if (reponse == "o")
            {
                Console.WriteLine("Est-ce que c'est un livre de (1)littérature, de (2)philosophie ou de (3)langues étrangères?");
                reponse=Console.ReadLine();
                if (reponse == "1" || reponse == "2" || reponse == "3")
                {
                    Console.WriteLine("Le livre appartient à la catégorie" + reponse);

                    Console.WriteLine("Est-il paru après 1995? o/n");
                    reponse = Console.ReadLine();
                    if (reponse == "o")
                    {
                        Console.WriteLine("Alors, je range le livre dans la bibliothèque.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Alors, je range le livre dans le carton BOITESCOL.");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("Alors, je range le livre dans le carton BOITESCOL.");
                    Console.ReadKey();    
                }

            }
            else                                    // Livre NON scolaire
            {
                Console.WriteLine("Est-ce un livre de poche? o/n");
                reponse = Console.ReadLine();
                if (reponse == "o")
                {
                    Console.WriteLine("A t'il été lu? o/n");
                    reponse = Console.ReadLine();
                    if (reponse == "o")
                    {
                        Console.WriteLine("Est ce que c'est un roman? o/n");
                        reponse = Console.ReadLine();
                        if (reponse == "o")
                        {
                            Console.WriteLine("Je le range dans BOITEROM");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Je le range dans BOITEDIV");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                            Console.WriteLine("Alors, je le range dans la bibliothèque");
                            Console.ReadKey();
                        
                    }
                }
                else
                {
                    Console.WriteLine("Est ce que le livre est détérioré? o/n");
                    reponse = Console.ReadLine();
                    if (reponse == "o")
                    {
                       Console.WriteLine("Est ce que c'est un roman? o/n");
                            reponse = Console.ReadLine();
                            if (reponse == "o")
                            {
                                Console.WriteLine("Je le range dans BOITEROM");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Je le range dans BOITEDIV");
                                Console.ReadKey();
                            }
                       
                      
                    }
                    else
                    {
                        Console.WriteLine("Je le range dans la bibliothèque");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine("reste-t-il encore un livre dans ma bibliothèque? o/n");
            reponse = Console.ReadLine();
            if (reponse == "n")
            {
                restelivre = false;  
            }
         } while (restelivre);

            Console.WriteLine("la bibliothèque est triée; il ne reste plus de livre!");
            Console.ReadKey();
        }
    }
}
