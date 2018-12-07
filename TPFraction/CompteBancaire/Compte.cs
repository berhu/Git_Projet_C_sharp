using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class Compte
    {
        /// <summary>
        /// Numero du compte
        /// </summary>
        private int numUnique;

        /// <summary>
        /// Nom du titulaire du compte
        /// </summary>
        private string nomProprio;

        /// <summary>
        /// Solde du compte
        /// </summary>
        private float soldeCompte;

        /// <summary>
        /// Découvert autorisé sur le compte
        /// La valeur est la valeur minimu possible du solde du compte
        /// Exemple : Pour un découvert autorisé de 100€, la valeur sera "-100"
        /// </summary>
        private float decouvertAutorise;

        /// <summary>
        /// Constructeur à vide
        /// </summary>
        public Compte()
        {
            numUnique = 0;
            nomProprio = "";
            soldeCompte = 0;
            decouvertAutorise = 1;
        }


        /// <summary>
        /// Accesseur pour l'attribut "decouvertAutorise"
        /// Permet de spécifier l'autorisation de découvert depuis l'extérieur de la classe
        /// </summary>
        public float DecouvertAutorise
        {
            get{return decouvertAutorise;}
            set{decouvertAutorise = value;}
        }

        public float SoldeCompte
        {
            get{return soldeCompte;}
            set{soldeCompte = value;}
        }

        public string NomProprio
        {
            get{return nomProprio;}
            set{nomProprio = value;}
        }

        public int NumUnique
        {
            get{return numUnique;}
            set{numUnique = value;}
        }



        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="_nomProprio"></param>
        /// <param name="_numUnique"></param>
        /// <param name="_soldeCompte"></param>
        /// <param name="_decouvertAutorise"></param>
        public Compte(string _nomProprio, int _numUnique, float _decouvertAutorise, float _soldeCompte = 0)
        {
            numUnique = _numUnique;
            nomProprio = _nomProprio;
            soldeCompte = _soldeCompte;
            decouvertAutorise = _decouvertAutorise;
        }

        

        /// <summary>
        /// Affichage des Informations du compte
        /// </summary>
        /// <returns>Une chaîne de caractère représentant les informations du compte</returns>
        public void /*string*/ Afficher()
        {
            //return "Nom : " + nomProprio + " \\ Numéro de compte : " + numUnique + " \\ Solde : " + soldeCompte;
            Console.WriteLine("Nom : " + nomProprio + " \\ Numéro de compte : " + numUnique + " \\ Solde : " + soldeCompte);
        }

        /// <summary>
        /// Créditer le compte d'un certain montant
        /// </summary>
        /// <param name="_montant">Le montant à créditer sur le compte(lavaleur doit être positive)</param>
        public void Crediter(float _montant)
        {
            if (_montant > 0)
            {
                soldeCompte += _montant;
            }
        }

        /// <summary>
        /// Débiter le compte d'un montant donné
        /// </summary>
        /// <param name="_montant"></param>
        /// <returns>TRUE si le débit a été accepté ou FALSE si le débit est refusé</returns>
        public  bool Debiter(float _montant)
        {
            if (_montant > 0 && (soldeCompte - _montant > decouvertAutorise))
            {
                soldeCompte -= _montant;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Transfère un montant du compte actuel vers le compte spécifié en paramètre
        /// </summary>
        /// <param name="_montant">Le montant à transférer</param>
        /// <param name="_autreCompte">Le compte créditeur du transfert</param>
        /// <returns></returns>
        public bool Transferer(float _montant, Compte _autreCompte)
        {
            if (this.Debiter(_montant)) //Si le débit du montant du compte actuel est accepté
            {
                _autreCompte.Crediter(_montant);   //Alors on crédite le compte destinataire
                return true;
            }
            return false;
        }
        

        /// <summary>
        /// Compare les soldes du compte actuel avec celui du compte envoyé en paramètre
        /// </summary>
        /// <param name="_autreCompte">le Compte à comparer</param>
        /// <returns>TRUE si le compte actuel est supérieur à _autreCompte. Sinon, False</returns>
        public bool Comparer(Compte _autreCompte)
        {
            return (soldeCompte > _autreCompte.soldeCompte);
        }

        

    }
}
