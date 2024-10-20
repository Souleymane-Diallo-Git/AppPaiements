using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement 
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string description, int numerocarte):base(montant, description) 
        {
            NumeroCarte = numerocarte;
        }


        public override void AfficherDetails() 
        {
            Console.WriteLine($"La CarteCrédit est dépensée ainsi : un montant de {Montant}, une description qui est un(e) {Description}, et le numero de la carte est {NumeroCarte}.");
        }


    }
}
