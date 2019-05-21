using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Newtonsoft.Json;
using System.Reflection;
using System.Data.Entity;

namespace StoreManagement_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            //register

            //var context = new StoreManagementDbContext();
            //Console.WriteLine("Enter your name");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter your email");
            //string mail = Console.ReadLine();
            //Console.WriteLine("Enter your address");
            //string adr = Console.ReadLine();
            //Console.WriteLine("Enter your date of brth");
            //string brthdt = Console.ReadLine();
            //DateTime brdt = DateTime.Parse(brthdt);
            //var cust1 = new Customer();
            //Console.WriteLine(cust1.CustomerRegister(mail, nm, adr, brdt));
            //context.Add(cust1);
            //context.SaveChanges();

            //update

            //Console.WriteLine("Enter new information");
            //Console.WriteLine("Enter your name");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter your email");
            //string mail = Console.ReadLine();
            //Console.WriteLine("Enter your address");
            //string adr = Console.ReadLine();
            //Console.WriteLine("Enter your date of brth");
            //string brthdt = Console.ReadLine();
            //DateTime brdt = DateTime.Parse(brthdt);
            //var nc = new Customer();
            //nc.UpDate(nm, adr, mail, brdt);

            //delete

            //Console.WriteLine("Enter your email");
            //string mail = Console.ReadLine();
            //var c = new Customer();
            //c.Delete(mail);

            //addbasket

            //////upload a basket with method
            ////var context = new StoreManagementDbContext();
            ////Console.WriteLine("Enter your email");
            ////string mail = Console.ReadLine();
            ////var nc = context.Set<Customer>().SingleOrDefault(Customer => Customer.Email == mail);
            ////nc.CreateBasket(mail);

            //    string ansr;
            //    var context = new StoreManagementDbContext();
            //    Console.WriteLine("Enter your email");
            //    string mail = Console.ReadLine();
            //    Console.WriteLine("Enter the code of the basket");
            //    string codeb = Console.ReadLine();
            //    int cb = int.Parse(codeb);
            //    var bask = context.Set<Baskets>().SingleOrDefault(Baskets => Baskets.BasketsId == cb);
            //    do
            //    {
            //        Console.WriteLine("Enter the code of the desire product");
            //        string code = Console.ReadLine();
            //        int c = int.Parse(code);
            //        var product = context.Set<Product>().SingleOrDefault(Product => Product.ProductId == c);
            //        bask.Products.Add(product);
            //        context.SaveChanges();
            //        Console.WriteLine("Add items? Y/N");
            //        ansr = Console.ReadLine();
            //    } while (ansr != "N");
            //    var cust = new Customer();
            //    cust.AddBasket(mail, bask);
            //    context.SaveChanges();

            //}

            //create a new basked hardcopy

            //var basket = new Baskets();
            //var pr = new Product()
            //{
            //    Name = "Mallas",
            //    Category = ProductCategoryId.Shoes,
            //    Price = 105M
            //};
            //basket.Products.Add(pr);
            //context.Add(pr);
            //context.SaveChanges();

            //var context = new StoreManagementDbContext();
            //var b = context.Set<Baskets>().Where(t => t.BasketsId == 10);
            //var c = new Customer();
            //c.DeleteBasket("agg@yahoo.com", b);
            //nc.DeleteBasket("agg@yahoo.com", b.BasketsId);

            //var baskets = context.Set<Baskets>()
            //.Include(b => b.Products).Where(product => product.BasketsId == 4).Include(b => b.Products).Where(product => product.BasketsId == 6);
            //context.Add<pr2, pr3>;
            //context.SaveChanges();
            ////basket.Products.Add(pr1);
            //context.SaveChanges();

            //foreach (var p in baskets)
            //{
            //    Console.WriteLine(p.ToString());
            //}


            ////basket.Products.Add(pr5);
            //context.Add(basket);
            //context.SaveChanges();
            //context.Add(pr5);
            //context.SaveChanges();

            //test DeleteBasket

            //var context = new StoreManagementDbContext();
            //var h = new Customer();
            //var r = context.Set<Baskets>().SingleOrDefault(b => b.BasketsId == 10); 
            //h.DeleteBasket("agg@yahoo.com", 10);
            //basket.Product.Add(
            //        new Product()
            //{
            //    Name = "Mallas",
            //            Category = ProductCategoryId.Shoes,
            //            Price = 105M
            //        });



            //test GetRecentCustomers

            //var context = new StoreManagementDbContext();
            //var h = new Customer();
            //foreach (var c in h.GetRecentCustomers())
            //{
            //    Console.WriteLine(c);
            //}




        }



    }
    
}