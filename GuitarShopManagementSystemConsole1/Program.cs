// See https://aka.ms/new-console-template for more information

using GuitarShopManagementSystem;
using GuitarShopManagementSystemModel.Model;

InventoryManager inventoryManager = new InventoryManager();
UserManager userManager = new UserManager();
CustomerModel customer = new CustomerModel();
CustomerManager customerManager = new CustomerManager();

Console.WriteLine("+----------------------------------------+");
Console.WriteLine("|             Guitar Shop                |");
Console.WriteLine("+----------------------------------------+");
Console.WriteLine("1. Login");
Console.WriteLine("2. Sign up");
Console.WriteLine("3. Guest User");
Console.Write("Enter an option: ");
int op = int.Parse(Console.ReadLine());
Console.Clear();

while (true)
{
    switch (op)
    {
        case 1:
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

                string wlcm;

                wlcm = $"WELCOME {userDetails.FName} {userDetails.LName}";
                Console.WriteLine(wlcm);
            }
            Console.WriteLine("1. Categories");
            Console.WriteLine("2. Shopping Cart");
            Console.Write("Enter an option: ");
            int op1 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (op1 == 1)
            {
                Console.WriteLine("Categories");
                inventoryManager.Categories();
            }
            break;
        case 2:
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("|         User Registration              |");
            Console.WriteLine("+----------------------------------------+");
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
            break;
        case 3:
            Console.WriteLine("WELCOME USER!");
            Console.WriteLine("1. Categories");
            Console.WriteLine("2. Shopping Cart");
            Console.Write("Enter an option: ");
            int op2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (op2 == 1)
            {
                Console.WriteLine("Categories");
                inventoryManager.Categories();
            }
            break;
    }
    break;
}