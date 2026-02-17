using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine
    {
        // La liste qui contient tous les objets "Produit"
        public List<Product> Inventory { get; set; }
        public decimal Balance { get; set; }

        public VendingMachine()
        {
            Inventory = new List<Product>();
            Balance = 0;
        }

        // Méthode pour ajouter de l'argent
        public void InsertMoney(decimal amount)
        {
            this.Balance += amount;
        }

        // Méthode pour acheter un produit
        public string BuyProduct(int id)
        {
            // 1. On cherche le produit dans la liste qui a le même Id que celui demandé
            Product productToBuy = Inventory.Find(p => p.Id == id);

            // 2. Si le produit n'est pas trouvé (null), on arrête tout
            if (productToBuy == null)
            {
                return "Erreur : Produit inconnu.";
            }

            // 3. Vérification du stock
            if (productToBuy.Stock <= 0)
            {
                return "Erreur : Rupture de stock.";
            }

            // 4. Vérification de l'argent
            if (this.Balance < productToBuy.Price)
            {
                return "Erreur : Fonds insuffisants.";
            }

            // 5. On procède à l'achat
            productToBuy.DecrementStock();
            this.Balance -= productToBuy.Price;

            return $"SUCCÈS : Voici votre {productToBuy.Name}.";
        }

        // Méthode pour rendre la monnaie
        public decimal ReturnChange()
        {
            decimal amountToReturn = this.Balance;
            this.Balance = 0;
            return amountToReturn;
        }
    }
}
