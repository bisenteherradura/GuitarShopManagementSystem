using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuitarShopManagementSystemModel.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string price { get; set; }
    }
}
