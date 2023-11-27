// See https://aka.ms/new-console-template for more information

using GuitarShopManagementSystem;

InventoryManager inventoryManager = new InventoryManager();

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
        case 3:
            Console.WriteLine("WELCOME USER!");
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
    }
    break;
}