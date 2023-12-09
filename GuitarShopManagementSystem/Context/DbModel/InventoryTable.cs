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
        private int _total;
        private int _quantity;
        public int Total 
        {
            get
            {
                return _total;
            }
            set
            {
                _total = _quantity * Price;
            } 
        }
        public int Quantity 
        {
            get
            {
                return _quantity;
            }
            set
            {

            } 
        }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
    }
}
