using StoreManagement_Customers_Baskets_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManagement_Proj
{
    public interface ICustomerService
    {
        string CustomerRegister(string email, string name, string address, DateTime birthDate);
        bool UpDate(string name, string address, string email, DateTime birthDate);
        bool Delete(string email);
        bool AddBasket(string email, Baskets basket);
        bool DeleteBasket(string email, int basketId);
        List<Customer> GetRecentCustomers();
    }
}
