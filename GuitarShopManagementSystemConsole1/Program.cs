// See https://aka.ms/new-console-template for more information

using GuitarShopManagementSystem;
using GuitarShopManagementSystemModel.Model;
using System.ComponentModel.Design;

UserManager userManager = new UserManager();
CustomerModel customer = new CustomerModel();
CustomerManager customerManager = new CustomerManager();
ShopManager shopManager = new ShopManager();

menu:
Console.WriteLine("+---------------------------------------+");
Console.WriteLine("            Vincent Guitars              ");
Console.WriteLine("+---------------------------------------+");
Console.WriteLine("1. Login");
Console.WriteLine("2. Sign up");
Console.WriteLine("3. Guest User");
Console.WriteLine("4. Exit");
Console.Write("Enter an option: ");
int op = int.Parse(Console.ReadLine());
Console.Clear();
while (true)
{
    switch (op)
    {
        case 1:

            while (true)
            {
                Console.Write("Username: ");
                customerManager.UserName = Console.ReadLine();
                Console.Write("Password: ");
                customerManager.Password = Console.ReadLine();
                int userId = customerManager.Login();

                if (userId != 0)
                {
                    customerManager.Id = userId;
                    CustomerManager.CustomerModel userDetails = customerManager.GetCustomerDetails();

                    Console.Clear();

                    string welcomeBanner1 = "+-----------------------------------+";
                    string welcomeBanner2 = $"        Welcome {userDetails.FName} {userDetails.LName.ToUpper()}";
                    string welcomeBanner3 = "+-----------------------------------+";

                    Console.WriteLine(welcomeBanner1);
                    Console.WriteLine(welcomeBanner2);
                    Console.WriteLine(welcomeBanner3);
                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("1. Shop by Category");
                        Console.WriteLine("2. Shopping Cart");
                        Console.WriteLine("3. Exit Application");
                        Console.Write("Enter an option: ");
                        int op1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (op1)
                        {
                            case 1:
                                Console.WriteLine("+---------------------------------------+");
                                Console.WriteLine("              Categories                ");
                                Console.WriteLine("+---------------------------------------+");
                                Console.WriteLine("1. Electric Guitars");
                                Console.WriteLine("2. Acoustic Guitars");
                                Console.WriteLine("3. Basses");
                                Console.WriteLine("4. Accessories");
                                Console.Write("Enter an option: ");
                                int op3 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                switch (op3)
                                {
                                    case 1:
                                        shopManager.ElectricGuitars();
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    // Add cases for other categories as needed

                                    default:
                                        Console.WriteLine("Invalid option. Please try again.");
                                        break;
                                    case 2:
                                        shopManager.AcousticGuitars();
                                        Console.ReadKey();  
                                        Console.Clear();
                                        break;
                                }
                                break;

                            case 2:
                                // Handle Shopping Cart
                                break;
                            case 3:
                                return;

                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        Console.WriteLine(welcomeBanner1);
                        Console.WriteLine(welcomeBanner2);
                        Console.WriteLine(welcomeBanner3);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Login failed. Invalid username or password. Please try again.");
                }
            }
        case 2:
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("         User Registration              ");
            Console.WriteLine("+---------------------------------------+");
            userManager.SignUp();
            Console.Clear();
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Phone Number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            customer.FName = firstName;
            customer.LName = lastName;
            customer.address = address;
            customer.PNum = phoneNumber;

            userManager.Register(customer);

            Console.WriteLine("Registration successful! Returning to the login menu...");
            Console.ReadKey(); // Optional: Wait for a key press to make it visible to the user
            Console.Clear();

            goto menu;
            break;
        case 3:
            while (true)
            {
                Console.WriteLine("+---------------------------------------+");
                Console.WriteLine("             Welcome USER!               ");
                Console.WriteLine("+---------------------------------------+");

                Console.WriteLine("1. Shop by Category");
                Console.WriteLine("2. Shopping Cart");
                Console.WriteLine("3. Exit Application");
                Console.Write("Enter an option: ");
                int op1 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op1)
                {
                    case 1:
                        Console.WriteLine("+---------------------------------------+");
                        Console.WriteLine("              Categories                ");
                        Console.WriteLine("+---------------------------------------+");
                        Console.WriteLine("1. Electric Guitars");
                        Console.WriteLine("2. Acoustic Guitars");
                        Console.WriteLine("3. Basses");
                        Console.WriteLine("4. Accessories");
                        Console.Write("Enter an option: ");
                        int op3 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (op3)
                        {
                            case 1:
                                shopManager.ElectricGuitars();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                shopManager.AcousticGuitars();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case 3:
                        return;
                }
            }
        case 4:
            return;
    }
    break;
}