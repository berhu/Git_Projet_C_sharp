using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_codage_fonction
{
    class Program
    {
        static void Main(string[] args)
        {
            bool saisien = false;
            
            int n = 0;

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

            SaisieFormation(ref tabF);
            Trier(ref tabF);
            Afficher(ref tabF);
          
            Console.ReadKey();
        }

        private static void Afficher(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine("Formation : " + _tabF[i, 0] + "; Nombre de stagiaires inscrits : " + _tabF[i, 1]);
            }
        }

        private static void Trier(ref string[,] _tabF)
        { 
            bool echange;
            string temp1, temp2;
            int maxi = _tabF.GetLength(0);

            do
            {

                echange = false;
                //parcours du tableau
                for (int i = 1; i <= maxi - 1; i++)
                {
                    //comparaison des deux cases successives
                    if (Convert.ToInt32(_tabF[i, 1]) < Convert.ToInt32(_tabF[i - 1, 1]))
                    {
                        //échange
                        temp1 = _tabF[i, 0];                //tmp = _tabF[i, 1;]
                        temp2 = _tabF[i, 1];                //_tabF[i, 1
                        _tabF[i, 0] = _tabF[i - 1, 0];      //
                        _tabF[i, 1] = _tabF[i - 1, 1];      //
                        _tabF[i - 1, 0] = temp1;            //
                        _tabF[i - 1, 1] = temp2;            //
                        echange = true;
                    }
                }
                maxi--;

            } while (echange && maxi > 0);
        }

        private static void SaisieFormation(ref string[,] _tabF)
        {
            string saisieN, saisieF;
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine("Veuillez saisir le nom de la formation recherchée : {0:0} -", i + 1);
                saisieF = Console.ReadLine();
                _tabF[i, 0] = saisieF;
                Console.WriteLine("Veuillez saisir les effectifs de la formation " + saisieF + " : ");
                saisieN = Console.ReadLine();
                _tabF[i, 1] = saisieN;
            }
        }
    }
}
