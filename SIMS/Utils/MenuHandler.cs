using SIMS.Domain;


namespace SIMS.Utils
{
    class MenuHandler
    {
        public static void ShowMainMenu()
        {
            Inventory inventory = new Inventory();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Inventory Management System ---");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Edit a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Search for a product");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option (1-6): ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string? name = Console.ReadLine();
                        Console.Write("Enter price: ");
                        decimal price = decimal.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine() ?? "0");

                        Product product = new Product(name ?? string.Empty, price, quantity);
                        inventory.AddProduct(product);
                        break;

                    case "2":
                        inventory.ViewAllProducts();
                        break;

                    case "3":
                        Console.Write("Enter the name of the product to edit: ");
                        string? editName = Console.ReadLine();
                        inventory.EditProduct(editName ?? string.Empty);
                        break;

                    case "4":
                        Console.Write("Enter the name of the product to delete: ");
                        string? deleteName = Console.ReadLine();
                        inventory.DeleteProduct(deleteName ?? string.Empty);
                        break;

                    case "5":
                        Console.Write("Enter the name of the product to search: ");
                        string? searchName = Console.ReadLine();
                        inventory.SearchProduct(searchName ?? string.Empty);
                        break;

                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting the application. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
