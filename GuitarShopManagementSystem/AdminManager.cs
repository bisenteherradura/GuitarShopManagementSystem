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
    public class AdminManager
    {
        public void addProduct(ProductModel product)
        {
            using (var context = new GuitarShopManagementSystemDBContext()) 
            {
                InventoryTable inventoryTable = new InventoryTable();
                inventoryTable.Quantity = product.Qty;
                inventoryTable.Brand = product.Brnd;
                inventoryTable.Model = product.Mdl;
                inventoryTable.Price = product.Prc;

                context.inventoryTable.Add(inventoryTable);
                context.SaveChanges();
            }
        }
        public void updateItem()
        {

        }
    }
}
