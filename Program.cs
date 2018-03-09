using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte cpt1 = new Compte();
            CompteEpargne cptEpargne = new CompteEpargne();
            ComptePayant cptPayant = new ComptePayant();

            cpt1.depot(5000);
            cptEpargne.depot(5000);
            cptPayant.depot(5000);

            cpt1.retrait(2000);
            cptEpargne.retrait(2000);
            cptPayant.retrait(2000);

        }
    }
}
