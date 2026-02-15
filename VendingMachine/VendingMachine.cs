using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Plus tard
        }

        // Méthode pour acheter un produit
        public string BuyProduct(int id)
        {
            // Plus tard
            return "";
        }

        // Méthode pour rendre la monnaie
        public decimal ReturnChange()
        {
            // Plus tard
            return 0;
        }
    }
}
