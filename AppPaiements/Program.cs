using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Ci-dessous sont affichés les instances créés de la classe CarteCrédit.\n");
        CarteCredit achat1 = new CarteCredit(300, "Chemise", 12345);
        CarteCredit achat2 = new CarteCredit(400, "Pantalon", 123456);
        CarteCredit achat3 = new CarteCredit(500, "Installation wifi", 123457);


        Paypal paiement1 = new Paypal(600, "Appartement", "maisonlouer@gmail.com");
        Paypal paiement2 = new Paypal(45, "Connexion", "numerotelephone@gmail.com\n\n");



        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();

        Console.WriteLine($"\n\n\nCi-dessous sont affichés les instances créés de la classe Paiement.\n");
        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
    }
}