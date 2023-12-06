using GuitarShopManagementSystem.Context;
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

                foreach (var guitar in electricGuitars)
                {
                    Console.WriteLine("+-----------------------------------------------------+");
                    Console.WriteLine($"|  Brand: {guitar.Brand,-22} |                    |");
                    Console.WriteLine($"|  Model: {guitar.Model,-22} | Price: {guitar.Price,11:C} |");
                }
                Console.WriteLine("+-----------------------------------------------------+");
            }
        }
        public void AcousticGuitars()
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var acousticGuitars = context.inventoryTable
                    .Where(guitar => guitar.Type.ToLower().Contains("acoustic"))
                    .ToList();

                foreach (var guitar in acousticGuitars)
                {
                    Console.WriteLine("+----------------------------------------------+");
                    Console.WriteLine($"|  Brand: {guitar.Brand,-15} |                    |");
                    Console.WriteLine($"|  Model: {guitar.Model,-15} | Price: {guitar.Price,8:C} |");
                }
                Console.WriteLine("+----------------------------------------------+");
            }
        }
        public void Order()
        {
            
        }
    }
}
