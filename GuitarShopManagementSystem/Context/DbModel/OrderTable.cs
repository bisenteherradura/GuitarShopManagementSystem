using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem.Context.DbModel
{
    public class OrderTable
    {
        [Key]
        public int OrderId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Price { get; set; }
    }
}
