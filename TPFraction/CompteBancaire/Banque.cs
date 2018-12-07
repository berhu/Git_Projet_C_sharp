using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class Banque
    {
        private int NbComptes;
        private Compte[] LesComptes;

        public Banque()
        {
            LesComptes = new Compte[20];
            NbComptes = 0;
        }
        public void Init()
        {
            Compte c1 = new Compte("Toto", 12345, -500, 1000);
            AjouteCompte(c1);

            Compte c2 = new Compte("Titi", 45657, -1000, 2000);
            AjouteCompte(c2);

            Compte c3 = new Compte("Dupond", 32345, -1500, 1500);
            AjouteCompte(c3);

            Compte c4 = new Compte("Durand", 11633, -500, 1200);
            AjouteCompte(c4);

            Compte c5 = new Compte("Dubois", 2568, -500, -200);
            AjouteCompte(c5);

            Compte c6 = new Compte("Duval", 8978, -2000, 750);
            AjouteCompte(c6);

        }
        private void AjouteCompte(Compte unCompte)
        {
            LesComptes[NbComptes++] = unCompte;
        }

        public void AjouteCompte(string _nomProprio, int _numUnique, float _decouvertAutorise, float _soldeCompte = 0)
        {
            Compte comptine = new Compte(_nomProprio, _numUnique, _decouvertAutorise, _soldeCompte);
            AjouteCompte(comptine);
        }

        public void AfficherComptes()
        {

            for (int i = 0; i < LesComptes.Length; i++)
            {
                if (LesComptes[i] != null)
                {
                    LesComptes[i].Afficher();
                }
            }
            
        }
        
        public void CompteSup()
        {
            int i = 0;
            Compte compteSoldeMax = LesComptes[0];
            float maximum = LesComptes[0].SoldeCompte;
            foreach (Compte moncompte in LesComptes)
            {
                if (moncompte != null && moncompte.SoldeCompte > maximum)
                {
                    maximum = moncompte.SoldeCompte;
                    compteSoldeMax = moncompte;
                }
                i++;
            }

            Console.WriteLine("\nLe compte avec le plus gros solde est : ");
            //Console.WriteLine("nombre de compte [i] = " + i);
            compteSoldeMax.Afficher();
        }

        public Compte RendCompte(int _numCompte)
        /*{
            for (int i = 0; i < LesComptes.Length; i++)
            {

            }
            return this;
        }*/
        {

            foreach (Compte item in LesComptes)
            {
                if (item!=null)
                {
                    if (_numCompte == item.NumUnique)
                    {

                        return item;
                    }
                }
            }
            return null;
        }

        public bool Transfert(int _numcompte, int _numcomptecred, float _montant)
        {
            RendCompte(_numcompte);
            RendCompte(_numcomptecred);
            //RendCompte(_numcompte).Afficher();
            //RendCompte(_numcomptecred).Afficher();

            if (RendCompte(_numcompte) != null && RendCompte(_numcomptecred) != null)               //Si le débit du montant du compte actuel est accepté
            {

                if (RendCompte(_numcompte).Debiter(_montant))
                {

                    RendCompte(_numcomptecred).Crediter(_montant);          //Alors on crédite le compte destinataire

                    //RendCompte(_numcompte).Afficher();
                    //RendCompte(_numcomptecred).Afficher();
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                Console.WriteLine("comptes inexistants!!");
                return false;
            }
            
        }
    }
}




