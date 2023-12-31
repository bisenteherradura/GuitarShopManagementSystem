﻿using GuitarShopManagementSystem.Context.DbModel;
using GuitarShopManagementSystem.Context;
using GuitarShopManagementSystemModel.Model;

namespace GuitarShopManagementSystem
{
    public class CustomerManager : UserManager
    {
        public class CustomerModel
        {
            public int Id { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string address { get; set; }
            public int PNum { get; set; }
        }
        public CustomerModel GetCustomerDetails()
        {
            using (var context = new GuitarShopManagementSystemDBContext())
            {
                var customerDetails = context.customerTable
                .Where(s => s.Id == Id)
                .Select(s => new CustomerModel
                {
                    Id = s.Id,
                    FName = s.FirstName,
                    LName = s.LastName
                })
                .FirstOrDefault();

                return customerDetails;
            }
        }
    }
}