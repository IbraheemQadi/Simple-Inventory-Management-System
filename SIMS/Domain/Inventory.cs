using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.Domain
{
    class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public void ViewAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products in inventory.");
                return;
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void EditProduct(string name)
        {
            var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter new name (leave empty to keep current): ");
            string? newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                product.Name = newName;
            }

            Console.Write("Enter new price (leave empty to keep current): ");
            string? priceInput = Console.ReadLine();
            if (decimal.TryParse(priceInput, out decimal newPrice))
            {
                product.Price = newPrice;
            }

            Console.Write("Enter new quantity (leave empty to keep current): ");
            string? quantityInput = Console.ReadLine();
            if (int.TryParse(quantityInput, out int newQuantity))
            {
                product.Quantity = newQuantity;
            }

            Console.WriteLine("Product updated.");
        }

    }
}
