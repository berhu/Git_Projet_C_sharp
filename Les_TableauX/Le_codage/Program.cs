using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_codage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool saisien = false;
            string saisieN, saisieF;
            int n = 0;
            bool test = true;




            do
            {
                Console.WriteLine("Veuillez saisir le nombre de filières que vous recherchez : ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    saisien = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Le format que vous avez choisi est incorrect, veuillez recommencer s'il vous plait !");
                }
            } while (!saisien);

            string[,] tabF = new string[n, 2];

            for (int i = 0; i < tabF.GetLength(0); i++)
            {
                Console.WriteLine("Veuillez saisir le nom de la formation recherchée : {0:0} -", i + 1);
                saisieF = Console.ReadLine();
                tabF[i, 0] = saisieF;
                Console.WriteLine("Veuillez saisir les effectifs de la formation " + saisieF + " : ");
                saisieN = Console.ReadLine();
                tabF[i, 1] = saisieN;
            }

            bool echange;
            string temp1, temp2;
            int maxi = tabF.GetLength(0);

            do
            {

                echange = false;
                //parcours du tableau
                for (int i = 1; i <= maxi - 1; i++)
                {
                    //comparaison des deux cases successives
                    if (Convert.ToInt32(tabF[i, 1]) < Convert.ToInt32(tabF[i - 1, 1]))
                    {
                        //échange
                        temp1 = tabF[i, 0];
                        temp2 = tabF[i, 1];
                        tabF[i, 0] = tabF[i - 1, 0];
                        tabF[i, 1] = tabF[i - 1, 1];
                        tabF[i - 1, 0] = temp1;
                        tabF[i - 1, 1] = temp2;
                        echange = true;
                    }
                }
                maxi--;

            } while (echange && maxi > 0);

            for (int i = 0; i < tabF.GetLength(0); i++)
            {
                Console.WriteLine("Formation : " + tabF[i, 0] + "; Nombre de stagiaires inscrits : " + tabF[i, 1]);            
            }
            Console.ReadKey();

        }
    }
}
