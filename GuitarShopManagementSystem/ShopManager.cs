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
                var guitars = context.inventoryTable.ToList();

                foreach (var guitar in guitars)
                {
                    Console.WriteLine("+----------------------------------------------+");
                    Console.WriteLine($"|  Brand: {guitar.Brand,-15} |                    |");
                    Console.WriteLine($"|  Model: {guitar.Model,-15} | Price: {guitar.Price,8:C} |");
                }
                Console.WriteLine("+----------------------------------------------+");
            }
        }
    }
}
