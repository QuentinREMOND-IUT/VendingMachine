namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine myMachine = new VendingMachine();

            myMachine.Inventory.Add(new Product(1, "Coca-Cola", 1.50m, 5));
            myMachine.Inventory.Add(new Product(2, "KitKat", 1.20m, 10));
            myMachine.Inventory.Add(new Product(3, "Eau Minérale", 0.80m, 20));

            // Boucle principale de l'application
            while (true)
            {
                // 1. On nettoie la console pour faire propre à chaque tour
                Console.Clear();

                Console.WriteLine("DISTRIBUTEUR AUTOMATIQUE 3000");
                Console.WriteLine("-----------------------------");

                // 2. On affiche l'inventaire
                foreach (Product p in myMachine.Inventory)
                {
                    Console.WriteLine($"[{p.Id}] {p.Name} \t: {p.Price} € \t(Stock: {p.Stock})");
                }
                Console.WriteLine("-----------------------------");

                // 3. On affiche le solde actuel et le menu
                Console.WriteLine($"SOLDE ACTUEL : {myMachine.Balance} €");
                Console.WriteLine("\nQue voulez-vous faire ?");
                Console.WriteLine("1. Insérer de l'argent");
                Console.WriteLine("2. Acheter un produit");
                Console.WriteLine("3. Rendre la monnaie");
                Console.WriteLine("Q. Quitter");

                // 4. On récupère le choix de l'utilisateur
                Console.Write("Votre choix : ");
                string choix = Console.ReadLine().ToUpper();

                // 5. On traite le choix avec un Switch
                switch (choix)
                {
                    case "1":
                        Console.Write("Montant à insérer : ");
                        decimal montant = decimal.Parse(Console.ReadLine());
                        myMachine.InsertMoney(montant);
                        break;

                    case "2":
                        Console.Write("Indiquez l'ID du produit : ");
                        int idProduit = int.Parse(Console.ReadLine());
                        string resultat = myMachine.BuyProduct(idProduit);
                        Console.WriteLine(resultat);

                        Console.WriteLine("Appuyez sur Entrée pour continuer...");
                        Console.ReadLine();
                        break;

                    case "3":
                        decimal monnaieRendue = myMachine.ReturnChange();
                        Console.WriteLine($"On vous rend : {monnaieRendue} €");
                        Console.WriteLine("Appuyez sur Entrée pour continuer...");
                        Console.ReadLine();
                        break;

                    case "Q":
                        Console.WriteLine("Merci et à bientôt !");
                        return;

                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            }
        }
    }
}