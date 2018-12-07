using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_Lemprunt
{
    class Program
    {
        
        //static void Main(string[] args)
        //{
            static void Main(string[] args)
		{


			float credit=MontantCredit(); 
			int duree=DureeCredit();
			float taux=TauxCredit();
			result(credit,duree,taux);
			Console.Read();
		}

		static float MontantCredit() 
		{
			bool ok=false; float _credit=0;
			do { 
				Console.Write("Montant de l'emprunt [Min:1000] ? "); 
				try { 
					_credit=float.Parse(Console.ReadLine().Replace(".",",").Trim());
					if(_credit<1000) {
						Console.WriteLine("Montant non valide [Min:1000], Recommencez..."); 
						ok=false;} else {ok=true;} // if/else
				} catch(Exception e) { 
					Console.WriteLine(e.GetType().ToString());
					Console.WriteLine("Montant non valide ! Recommencez...");
				} // try/catch
			}  while(ok==false); // do/while
			return _credit; // Montant du crédit validé
		} // MontantCredit()

		static int DureeCredit() 
		{
			bool ok=false; int _duree=0;
			do {
				Console.Write("Durée du crédit en mois [Min:2 - Max:360]? ");
				try	{
					_duree=int.Parse(Console.ReadLine().Trim()); 
					if((_duree<2) | (_duree>360)) {
						Console.WriteLine("Durée non valide [Min:2 - Max:360], Recommencez..."); 
						ok=false;} else {ok=true;} // if/else
				} catch(Exception e) {
					Console.WriteLine(e.GetType().ToString());
					Console.WriteLine("Durée non valide ! Recommencez..."); 
				} // try/catch
			} while(ok==false);  // do/while
			return _duree; // Durée du crédit validée
		} // DureeCredit()

		static float TauxCredit() 
		{
			bool ok=false; float _taux=0;
			do {
				Console.Write("Taux d'intérêts du crédit [Min:1.5 - Max:20.5]? ");
				try	{
					_taux=float.Parse(Console.ReadLine().Replace(".",",").Trim()); 
					if((_taux<1.5f) | (_taux>20.5f)) 
                    {
						Console.WriteLine("Taux non valide [Min:1.5 - Max:20.5], Recommencez..."); 
						ok=false;
					} else {ok=true;} // if/else
				} catch(Exception e) {
					Console.WriteLine(e.GetType().ToString());
					Console.WriteLine("Durée non valide ! Recommencez..."); 
				} // try/catch
			} while(ok==false);  // do/while
			return _taux; // Taux du crédit validé
		} // TauxCredit()

		static void result(float credit, int duree, float taux)
		{
			

			
 

			// Juste pour le calcul du montant de l'échéance (Mensualité à payer)
			float Tp=((taux/100)/12); // Taux périodique du crédit
			float Tpx=1+Tp; 
			// Pour le tableau d'amortissement du crédit:
			float reste=credit; // Le reste du crédit
 			float capital=0; // Le capital du crédit
			float interet=0; // Intérêt du crédit
			Tpx=(float)Math.Pow(Tpx,duree); 
			float mensualite=(credit*Tpx*Tp)/(Tpx-1); // Le montant de l'échéache
			try
			{
				System.IO.StreamWriter fichier = new System.IO.StreamWriter("c:\\simulation.html");
				fichier.AutoFlush=true;
				fichier.WriteLine("<html><head><title>Simulation</title></head>");
				fichier.WriteLine("<body leftmargin=10 topmargin=10 rightmargin=10 bottommargin=10>");
				fichier.WriteLine("<font size=3 color='#000080' face='Arial'>");
				fichier.WriteLine("<b>&#160&#187&#160&#160Montant de l&#146emprunt : " + credit.ToString()+"<br>");
				fichier.WriteLine("&#160&#187&#160&#160Dur&#233e : "+duree.ToString()+" Mois<br>");
				fichier.WriteLine("&#160&#187&#160&#160Taux annuel du pr&#234t : "+taux.ToString()+"%<br>");
				fichier.WriteLine("<font color='red'>&#160&#187&#160&#160Mensualit&#233 du cr&#233dit : "+mensualite.ToString()+"</font><br>");
				fichier.WriteLine("&#160&#187&#160&#160Assurance mensuelle : 0<br>");
				fichier.WriteLine("&#160&#187&#160&#160Frais additionnelles : 0</font></b><br><br>");
				fichier.WriteLine("<table width='65%' border=1 bordercolor='#000080'>");
				fichier.WriteLine("<caption><font color='#000080' size=3><b>TABLEAU D&#146AMORTISSEMENT CREDIT</b></font></caption>");
				fichier.WriteLine("<tr bgcolor='#99ccff'><font color='#000080' size=2 face='Arial'><td><b>N&#186 Ech&#233ance</b></td>");
				fichier.WriteLine("<td><b>Cr&#233dit</b></td><td><b>Capital</b></td><td><b>Int&#233r&#234t</b></td><td><b>Mensualit&#233</b></td></font></tr>");
				for(int i=1; i<=duree; i++) // Tableau d'amortissement
				{
					interet=((reste*(taux/100))/12);
					capital=mensualite-interet;
					reste-=capital;
					string L; // Les colonnes du tableau
					L="<tr><td>"+i.ToString()+"</td>"; // L'actuelle échéance
					L+="<td>"+reste.ToString()+"</td>"; // Reste crédit pour l'actuelle échéance
					L+="<td>"+capital.ToString()+"</td>"; // Capital prélevé pour l'actuelle échéance
					L+="<td>"+interet.ToString()+"</td>"; // Intérêt prélevé pour l'actuelle échéance
					L+="<td>"+mensualite.ToString()+"</td></tr>"; // Mensualité
					fichier.WriteLine(L); 			
				} // for 
				fichier.WriteLine("</table></body></html>");
				fichier.Close();
				Console.WriteLine("\r\n"+"Les informations sont stockés dans un fichier texte.");
				Console.WriteLine("Chemin du fichier est: C:\\simulation.html"); 
			} catch(Exception e){
				Console.WriteLine("L'erreur suivante c'est produite:");
				Console.WriteLine(e.GetType().ToString());
				Console.WriteLine(e.Message);
			} // try/catch */
        }
        }
    }

