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

            Console.WriteLine("Bonjour ! Voici les produits disponibles :");
            Console.WriteLine("------------------------------------------");

            foreach (Product p in myMachine.Inventory)
            {
                Console.WriteLine($"[{p.Id}] {p.Name} \t: {p.Price} euros");
            }

            Console.WriteLine("------------------------------------------");

            Console.ReadLine();

            Console.WriteLine("\n--- Test d'achat ---");

            myMachine.InsertMoney(2.00m);
            Console.WriteLine("Argent inséré : 2.00 euros");

            string resultat = myMachine.BuyProduct(1);
            Console.WriteLine(resultat);

            Console.WriteLine($"Monnaie restante : {myMachine.ReturnChange()} euros");

            Console.ReadLine();
        }
    }
}