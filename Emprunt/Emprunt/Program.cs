using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            double kal, txAnn = 0;
            double partInteret, partCapital, restantDu, mensualite;
            uint annee;
            bool testc = false;

            Console.WriteLine("Quelle somme voulez vous emprunter ?");
            kal = double.Parse(Console.ReadLine());

            Console.WriteLine("Sur quelle durée en année(s), voulez vous emprunter ?");
            annee = uint.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Veuillez saisir le taux en % que nous vous proposons.");
                try
                {
                    string taux = Console.ReadLine();
                    taux = taux.Replace('.', ',');
                    txAnn = double.Parse(taux);
                    testc = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Veuillez recommencer la saisie.");
                }
            } while (!testc);

            uint mois = annee * 12;
            mensualite = CalculMensualite(kal, txAnn, annee);

            Console.WriteLine("Vous devrez rembourser : {0:#,##0.00} € pendant {1} mois", mensualite, mois);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("----------------Tableau d'amortissement---------------\n");
            Console.WriteLine("Num mois\tPart interet\tPart Capital\tCapital restant dû\tMensualité");
            Console.WriteLine(Environment.NewLine);

            double txm = txAnn / (12 * 100);
            restantDu = kal;
            double coutCredit = 0;

            for (int i = 1; i <= mois; i++)
            {

                partInteret = restantDu * txm;
                coutCredit += partInteret;
                partCapital = mensualite - partInteret;
                restantDu -= partCapital;                   //restantDu = restantDu - partCapital;

                Console.WriteLine(" {0} \t\t| {1:#,###.00} \t| {2:#,###.00} \t| {3:#,###.00} \t| {4:#,###} ", i, partInteret, partCapital, restantDu, mensualite);
            }
            coutCredit = Math.Round(coutCredit, 2);
            Console.WriteLine("Coût du crédit : " + coutCredit + "euros");

            Console.ReadKey();
        }
        public static double CalculMensualite(double _kal, double _txAnn, uint _annee)
        {
            double mensualite;
            uint mois = _annee * 12;
            double txm = _txAnn / (12 * 100);
            double Q = (1 - (Math.Pow(1 + txm, -mois)));
            mensualite = _kal * txm / Q;
            return mensualite;
        }
    }
}
