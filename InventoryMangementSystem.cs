using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    internal class InventoryMangementSystem
    {
        static List<Product> inventory = new List<Product>();
        public static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine(" INVENTORY MANAGEMENT SYSTEM");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Inventory Summary");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input!");
                    Pause();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;

                    case 2:
                        ViewProducts();
                        break;

                    case 3:
                        SearchProduct();
                        break;

                    case 4:
                        UpdateProduct();
                        break;

                    case 5:
                        DeleteProduct();
                        break;

                    case 6:
                        InventorySummary();
                        break;

                    case 7:
                        Console.WriteLine("Thank You!");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        Pause();
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.Clear();

            Product product = new Product();

            Console.Write("Enter Product ID: ");
            product.ProductId = int.Parse(Console.ReadLine());

            if (inventory.Any(p => p.ProductId == product.ProductId))
            {
                Console.WriteLine("Product ID already exists!");
                Pause();
                return;
            }

            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Enter Category: ");
            product.Category = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            product.Price = double.Parse(Console.ReadLine());

            inventory.Add(product);

            Console.WriteLine("\nProduct Added Successfully!");
            Pause();
        }

        static void ViewProducts()
        {
            Console.Clear();

            if (inventory.Count == 0)
            {
                Console.WriteLine("No Products Available.");
                Pause();
                return;
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("ID\tName\t\tCategory\tQty\tPrice");
            Console.WriteLine("----------------------------------------------------------------------------");

            foreach (Product p in inventory)
            {
                Console.WriteLine($"{p.ProductId}\t{p.ProductName}\t\t{p.Category}\t\t{p.Quantity}\t{p.Price}");
            }

            Pause();
        }

        static void SearchProduct()
        {
            Console.Clear();

            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Product product = inventory.Find(p => p.ProductId == id);

            if (product != null)
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine("------------------------");
                Console.WriteLine("ID       : " + product.ProductId);
                Console.WriteLine("Name     : " + product.ProductName);
                Console.WriteLine("Category : " + product.Category);
                Console.WriteLine("Quantity : " + product.Quantity);
                Console.WriteLine("Price    : ₹" + product.Price);
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }

            Pause();
        }

        static void UpdateProduct()
        {
            Console.Clear();

            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Product product = inventory.Find(p => p.ProductId == id);

            if (product == null)
            {
                Console.WriteLine("Product Not Found.");
                Pause();
                return;
            }

            Console.Write("Enter New Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Enter New Category: ");
            product.Category = Console.ReadLine();

            Console.Write("Enter New Quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter New Price: ");
            product.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Product Updated Successfully.");
            Pause();
        }

        static void DeleteProduct()
        {
            Console.Clear();

            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Product product = inventory.Find(p => p.ProductId == id);

            if (product != null)
            {
                inventory.Remove(product);
                Console.WriteLine("Product Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }

            Pause();
        }

        static void InventorySummary()
        {
            Console.Clear();

            Console.WriteLine("Inventory Summary");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Total Products : " + inventory.Count);

            double totalValue = 0;

            foreach (Product p in inventory)
            {
                totalValue += p.Quantity * p.Price;
            }

            Console.WriteLine("Total Inventory Value : ₹" + totalValue);

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to Continue...");
            Console.ReadLine();
        }

    }
}
