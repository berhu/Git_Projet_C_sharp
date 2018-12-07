using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginV2
{
    public struct Utilisateur
    {

        //attribut (variables)
        private string nom;
        private string login;
        private string motDePasse;
        public int niveauAcces;
        public string mail;
        private string qualification;
        //propriétés
        public string MotDePasse
        {
            get { return motDePasse; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Qualification
        {
            get
            {
                return qualification;
            }

        }

        //constructeur
        public Utilisateur(string _nom, string _login, string _motDePasse, int _niveau, string _mail, string _qualification)
        {
            this.nom = _nom;
            this.login = _login;
            this.motDePasse = _motDePasse;
            this.niveauAcces = _niveau;
            this.mail = _mail;
            this.qualification = _qualification;
        }



    }
}
