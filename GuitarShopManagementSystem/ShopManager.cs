using GuitarShopManagementSystem.Abstraction;
using GuitarShopManagementSystem.Context;
using GuitarShopManagementSystem.Context.DbModel;
using GuitarShopManagementSystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem
{
    public class ShopManager : CheckoutProcess
    {
        public override void Checkout(InventoryTable inventory)
        {
            Console.WriteLine("Choose Shipping options");
            Console.WriteLine("1. Cash on Delivery");
            Console.WriteLine("2. Credit Card");
            Console.Write("Enter shipping option: ");
            int shipping = int.Parse(Console.ReadLine());
            Console.Clear();

            if (shipping == 1 ) 
            {
                Console.WriteLine($"Thank you for purchasing {inventory.Brand} {inventory.Model} for {inventory.Price:C}!");
            }
            else if (shipping == 2 )
            {
                Console.Write("Enter your credit card number: ");
                string creditCardNumber = Console.ReadLine();
                Thread.Sleep(2000);
                Console.Clear();

                if (IsCreditCardValid(creditCardNumber))
                    {
                        Console.WriteLine($"Credit card payment processed successfully for {inventory.Price:C}.");
                        Console.WriteLine($"Thank you for purchasing {inventory.Brand} {inventory.Model}!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid credit card number. Payment failed.");
                    }
            }
        }
        private bool IsCreditCardValid(string creditCardNumber)
        {
            return creditCardNumber.Length == 16 && creditCardNumber.All(char.IsDigit);
        }
        public void ElectricGuitars()
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var electricGuitars = context.inventoryTable
                    .Where(guitar => guitar.Type.ToLower().Contains("electric"))
                    .ToList();

                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("               Electric Guitars           ");
                Console.WriteLine("+--------------------------------------------+");

                for (int i = 0; i < electricGuitars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {electricGuitars[i].Brand} {electricGuitars[i].Model} - {electricGuitars[i].Price:C}");
                }

                Console.Write("Enter the number of product: ");
                int userChoice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (userChoice >= 1 && userChoice <= electricGuitars.Count)
                {
                    var selectedGuitar = electricGuitars[userChoice - 1];

                    Console.WriteLine($"{selectedGuitar.Brand} {selectedGuitar.Model} ");
                    Console.WriteLine($"{selectedGuitar.Price:C}");
                    Console.WriteLine("");
                    Console.WriteLine("Product Description:");
                    FormatDescription(selectedGuitar.Description);

                    Console.WriteLine("");
                    Console.WriteLine("1. Buy");
                    Console.WriteLine("2. Add to Cart");
                    Console.Write("Enter an option: ");
                    int option2 = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (option2)
                    {
                        case 1:
                            Checkout(selectedGuitar);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a valid product number.");
                }
            }
        }
        public void AcousticGuitars()
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var acousticGuitars = context.inventoryTable
                    .Where(guitar => guitar.Type.ToLower().Contains("acoustic"))
                    .ToList();

                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("               Acoustic Guitars           ");
                Console.WriteLine("+--------------------------------------------+");

                for (int i = 0; i < acousticGuitars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {acousticGuitars[i].Brand} {acousticGuitars[i].Model} - {acousticGuitars[i].Price:C}");
                }

                Console.Write("Enter the number of product: ");
                int userChoice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (userChoice >= 1 && userChoice <= acousticGuitars.Count)
                {
                    var selectedGuitar = acousticGuitars[userChoice - 1];

                    Console.WriteLine($"{selectedGuitar.Brand} {selectedGuitar.Model} ");
                    Console.WriteLine($"{selectedGuitar.Price:C}");
                    Console.WriteLine("");
                    Console.WriteLine("Product Description:");
                    FormatDescription(selectedGuitar.Description);
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a valid product number.");
                }
            }
        }

        const int MaxLineLength = 50;
        static void FormatDescription(string description)
        {
            int startIndex = 0;

            while (startIndex < description.Length)
            {
                int endIndex = startIndex + MaxLineLength;

                if (endIndex >= description.Length)
                {
                    Console.WriteLine($"{description.Substring(startIndex)}");
                }
                else
                {
                    while (endIndex > startIndex && !char.IsWhiteSpace(description[endIndex]))
                    {
                        endIndex--;
                    }

                    Console.WriteLine($"{description.Substring(startIndex, endIndex - startIndex)}");
                }

                startIndex = endIndex + 1;
            }
        }
    }
}
