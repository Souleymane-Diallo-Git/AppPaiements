using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit achat1 = new CarteCredit(300, "Chemise", 12345);
        CarteCredit achat2 = new CarteCredit(400, "Pantalon", 123456);
        CarteCredit achat3 = new CarteCredit(500, "Installation wifi", 123457);


        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();
    }
}