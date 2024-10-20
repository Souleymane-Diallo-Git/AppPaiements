﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; } 

        public Paypal(double montant, string description, string email) : base (montant, description) 
        {
            Courriel = email;
        }


        public override void AfficherDetails() 
        {
            Console.WriteLine($"Le Paypal contient : Un montant de {Montant}, une description dont un(e) {Description}, et le courriel utilisé est {Courriel}");
        }
    }
}
