using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime1
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                //c'est le week end
                WeekEnd.AfficherBonWeekEnd();
            }
            else
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
                {
                    //lundi matin
                    WeekEnd.AfficherBonWeekEnd();
                }
                else
                {
                    if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                    {
                        //c'est la journée
                        Salutation.AfficherBonjour();
                    }
                    else
                    {
                        //C'est la soirée
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > 18)
                        {
                            //Vendredi soir
                            WeekEnd.AfficherBonWeekEnd();
                        }
                        else
                        {
                            Salutation.AfficherBonsoir();
                        }
                        
                    }
                }
            }
            Console.ReadKey();
        }     
    }
}
