using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire_CorrigeFranck
{
     class Compte : IDisposable
    {
        private int numero;
        private string nomProprietaire { get; set; }
        private float solde;
        private float decouvertAutorise;



        //propriété
        public int getNumero() { return this.numero; }
        public float getdecouvertAutorise() { return this.decouvertAutorise; }
        public float Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        //Constructeur
        public Compte()
        {
            Random alea = new Random();
            this.numero = alea.Next(10000, 100000);
            this.nomProprietaire = "Compte technique";
            this.solde = 0.00F;
            this.decouvertAutorise = 0.00F;

        }
        public Compte(int _num, string _nomProprio, float _solde, float _decouvertAuto)
        {
            this.numero = _num;
            this.nomProprietaire = _nomProprio;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAuto;
        }
        //méthodes
        public override string ToString()
        {
            string chaine = "Ce compte a pour numéro : " + numero + ", a pour propriétaire : " + nomProprietaire + ", son solde est de : " + solde + "\net son découvert autorisé est de : " + decouvertAutorise;
            return chaine;
        }
        public void Afficher()
        {
            Console.WriteLine(this/*.ToString()*/);
        }
        public void Crediter(float _montant)
        {
            this.Solde += _montant;
        }
        public bool Debiter(float _montant)
        {
            bool autorisation = false;
            float nouvSolde = this.Solde - _montant;
            if (nouvSolde >= this.decouvertAutorise)
            {
                autorisation = true;
                this.Solde -= _montant;
                return autorisation;
            }
            else
            {
                return autorisation;
            }
        }
        public bool Transferer(float _montant, Compte _autreCompte)
        {
            if (this.Debiter(_montant))
            {
                this.Debiter(_montant);
                _autreCompte.Crediter(_montant);
                return true;
            }
            return false;
        }
        public bool Superieur(Compte _autreCompte)
        {
            if (this.Solde > _autreCompte.Solde)
            {
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
