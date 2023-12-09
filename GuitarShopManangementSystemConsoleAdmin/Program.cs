// See https://aka.ms/new-console-template for more information

using GuitarShopManagementSystem;
using GuitarShopManagementSystem.Context.DbModel;
using GuitarShopManagementSystemModel.Model;

AdminManager admin = new AdminManager();    
ProductModel product = new ProductModel();

while (true)
{
    Console.WriteLine("+-----------------------------------+");
    Console.WriteLine("               Admin                 ");
    Console.WriteLine("+-----------------------------------+");

    Console.WriteLine("1. Restock Items");
    Console.WriteLine("2. Delete Items");
    Console.WriteLine("3. Update Items");
    Console.WriteLine("4. Exit");
    Console.Write("Enter option: ");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Type: ");
            string type = Console.ReadLine();
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price: ");
            string price = Console.ReadLine();

            product.Qty = quantity;
            product.Typ = type;
            product.Brnd = brand;
            product.Mdl = model;
            product.Prc = price;

            admin.addProduct(product);

            Console.WriteLine("Product successfully added");
            break;
        case 4:
            return;
    }
}

