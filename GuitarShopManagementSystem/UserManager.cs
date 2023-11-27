using GuitarShopManagementSystem.Context;
using GuitarShopManagementSystem.Context.DbModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem
{
    public class UserManager
    {
        public void SignUp()
        {
            Console.WriteLine("User Registration");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Phone Number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            using (var context = new GuitarShopManagementSystemDBContext())
            {
                CustomerTable customerTable = new CustomerTable();

                Console.WriteLine("User successfully registered!");
            }
        }
    }
}
