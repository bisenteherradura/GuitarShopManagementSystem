using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem.Context.DbModel
{
    public class InventoryTable
    {
        [Key]public int ProductId {  get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
    }
}
