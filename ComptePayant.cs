using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class ComptePayant : Compte
    {
        public new void depot(double montant)
        {
            Solde = (Solde + montant) - 5;
        }

        public new void retrait(double montant)
        {
            Solde = (Solde - montant) - 5;
        }

    }
}
