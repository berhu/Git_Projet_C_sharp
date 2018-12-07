using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicules
{
    abstract class Vehicule
    {
        private int Matricule;
        private int AnneeModele;
        private double Prix;
        private static int nb_vehicules = 0;

        public int Matricule1
        {
            get
            {
                return Matricule;
            }

        }

        public int AnneeModele1
        {
            get
            {
                return AnneeModele;
            }

            set
            {
                AnneeModele = value;
            }
        }

        public double Prix1
        {
            get
            {
                return Prix;
            }

            set
            {
                Prix = value;
            }
        }

        public static int Nb_vehicules
        {
            get
            {
                return nb_vehicules;
            }

        }
        public Vehicule(int _AnneeModele, double _Prix)
        {
            nb_vehicules++;
            Matricule = nb_vehicules;
            AnneeModele = _AnneeModele;
            Prix = _Prix;
        }
        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return "Matricule : " + Matricule + "\nModèle : " + AnneeModele + "\nPrix : " + Prix;
        }
    }
}


    









