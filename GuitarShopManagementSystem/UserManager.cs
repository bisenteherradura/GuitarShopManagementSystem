using GuitarShopManagementSystem.Context;
using GuitarShopManagementSystem.Context.DbModel;
using GuitarShopManagementSystemModel.Model;
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
        public void Register(CustomerModel customer)
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var user = context.userTable.OrderByDescending(u => u.UserId).FirstOrDefault();

                CustomerTable customerTable = new CustomerTable();

                customerTable.User = user;
                customerTable.FirstName = customer.FName;
                customerTable.LastName = customer.LName;
                customerTable.Address = customer.address;
                customerTable.PhoneNum = customer.PNum;

                context.customerTable.Add(customerTable);
                context.SaveChanges();

                Console.WriteLine("User successfully registered!");
            }
        }
        public void SignUp()
        {
            Console.WriteLine("User Registration");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var user = new UserTable { Username = username, Password = password };

                // Add the user to the context
                context.userTable.Add(user);

                // Save changes to the database
                context.SaveChanges();
            }
        }

        public string? UserName;
        public string? Password;
        public int Id;
        public virtual int Login()
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {

                var user = context.userTable
                    .Where(u => u.Username == UserName && u.Password == Password)
                    .FirstOrDefault();

                return user != null ? user.UserId : 0;
            }
        }
    }
}
