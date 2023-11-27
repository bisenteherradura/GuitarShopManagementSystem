using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem.Context.DbModel
{
    public class UserTable
    {
        [Key]public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
