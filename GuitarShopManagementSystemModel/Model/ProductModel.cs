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
        public int Qty { get; set; }
        public string Brnd { get; set; }
        public string Mdl { get; set; }
        public string price { get; set; }
    }
}
