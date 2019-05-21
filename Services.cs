using StoreManagement_Proj;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace StoreManagement_Customers_Baskets_Products
{
    public class CServices : ICustomerService
    {
        
        public string CustomerRegister(string email, string name, string address, DateTime birthDate)
        {
            var h = new Customer();
            h.CustomerName = name;
            h.Address = address;
            h.Email = email;
            h.Dob = birthDate;
            h.Register = DateTime.Now.ToString();
            h.Active = true;
            return h.ToString();
        }

        public bool UpDate(string name, string address, string email, DateTime birthDate)
        {


            bool con;
            bool ret;
            bool ansr;
            var context = new StoreManagementDbContext();
            do
            {
                Console.WriteLine("Enter your current email");
                string currentMail = Console.ReadLine();
                var cust = context.Set<Customer>().SingleOrDefault(Customer => Customer.Email == currentMail);
                try
                {
                    cust.CustomerName = name;
                    cust.Address = address;
                    cust.Email = email;
                    cust.Dob = birthDate;
                    context.SaveChanges();
                    con = true;
                    ansr = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please try again");
                    con = false;
                    Console.WriteLine("Continue (Yes/No)");
                    string answer = Console.ReadLine();

                    if (answer == "Yes")
                    {
                        ret = true;
                    }
                    else
                    {
                        ret = false;
                    }
                    ansr = ret;

                }
            } while (!con && ansr);
            return true;

        }

        public bool Delete(string email)
        {
            var context = new StoreManagementDbContext();
            var cust = context.Set<Customer>().SingleOrDefault(Customer => Customer.Email == email);
            try
            {
                cust.Active = false;
                Console.WriteLine("Successfully Deleted");
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Try again");
            }
            return true;

        }

        public bool AddBasket(string email, Baskets basket)
        {
            var context = new StoreManagementDbContext();
            var cust = context.Set<Customer>().SingleOrDefault(Customer => Customer.Email == email);
            int cid = cust.CustomerId;
            int bid = basket.BasketsId;
            var bs = context.Set<Baskets>().SingleOrDefault(b => b.BasketsId == bid);

            bs.Customer = cust;
            cust.Baskets.Add(bs);
            context.SaveChanges();
            return true;

        }

        public Baskets CreateBasket(string email)
        {
            string ansr;
            var context = new StoreManagementDbContext();
            Console.WriteLine("Enter the code of the basket");
            string codeb = Console.ReadLine();
            int cb = int.Parse(codeb);
            var bask = context.Set<Baskets>().SingleOrDefault(Baskets => Baskets.BasketsId == cb);
            do
            {
                Console.WriteLine("Enter the code of the desire product");
                string code = Console.ReadLine();
                int c = int.Parse(code);
                var product = context.Set<Product>().SingleOrDefault(Product => Product.ProductId == c);
                bask.Products.Add(product);
                context.SaveChanges();
                Console.WriteLine("Add items? Y/N");
                ansr = Console.ReadLine();
            } while (ansr != "N");
            var cust = new Customer();
            AddBasket(email, bask);
            context.SaveChanges();
            return bask;
        }

        public bool DeleteBasket(string email, int basketId)
        {
            var context = new StoreManagementDbContext();
            Customer cust = context.Set<Customer>().SingleOrDefault(t => t.Email == email);
            var bs = context.Set<Baskets>().SingleOrDefault(b => b.BasketsId == basketId);
            bs.Customer = cust;
            cust.Baskets.Remove(bs);
            context.SaveChanges();
            return true;
        }

        public List<Customer> GetRecentCustomers()
        {
            var context = new StoreManagementDbContext();
            var customerList = new List<Customer>();
            var cust = context.Set<Customer>();
            customerList = new List<Customer>();
            foreach (var c in cust)
            {
                DateTime ParsedDate = DateTime.Parse(c.Register);

                if (ParsedDate.AddDays(7) >= DateTime.Today)
                {
                    customerList.Add(c);
                }
            }

            return customerList;

        }

    }
}
