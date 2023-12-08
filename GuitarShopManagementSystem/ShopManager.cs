using GuitarShopManagementSystem.Context;
using GuitarShopManagementSystem.Context.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem
{
    public class ShopManager
    {
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
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a valid product number.");
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

    }
}
