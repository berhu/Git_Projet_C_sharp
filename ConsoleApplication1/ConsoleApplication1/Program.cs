﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;


            Console.WriteLine("Lecture de l'énoncé");
            Console.WriteLine("Avez-vous compris l'énoncé? o/n");
            reponse = Console.ReadLine();
            if (reponse == "n")
            {
                Console.WriteLine("relecture de l'énoncé");
                Console.WriteLine("Avez-vous compris l'énoncé? o/n");
                reponse = Console.ReadLine();
                if (reponse == "n")
                {
                    Console.WriteLine("Appel du formateur");
                    Console.WriteLine("Passer à l'énoncé suivant ! sortie 1 form");

                    Console.ReadKey();

                }
                else
                {

                    Console.WriteLine("Passer à l'énoncé suivant ! Sortie 2 relecture");

                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("Passer à l'énoncé suivant ! Sortie 3 compréhension");

                Console.ReadKey();
            }



        }
    }
}
