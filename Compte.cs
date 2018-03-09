using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Compte
    {
        private double solde;
        private int code;
        private int numcompte;

        public double Solde
        {
            set { solde = value; }
            get { return solde; }
        }

        public Compte()
        {
            solde = 0;
        }

        public Compte( double solde)
        {
            this.solde = solde;
        }

        public void depot(double montant)
        {
            solde = solde + montant;
        }

        public void retrait(double montant)
        {
            solde = solde - montant;
        }

        public new String ToString()
        {
            return "votre solde est " + solde;
        }


    }
}
