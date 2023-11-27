using GuitarShopManagementSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem
{
    public class InventoryManager
    {
        public void Categories()
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var query = from inventory in context.inventoryTable
                            select inventory;

                var inventoryList = query.ToList();

                foreach (var item in inventoryList)
                {
                    Console.WriteLine($"{item.Brand}");
                }
            }
        }

    }
}
