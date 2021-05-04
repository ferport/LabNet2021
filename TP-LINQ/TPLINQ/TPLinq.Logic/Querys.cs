using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLinq.Data;
using TPLinq.Entities;


namespace TPLinq.Logic
{
    public class Querys
    {
        protected readonly NorthwindContext context;

        public Querys()
        {
            context = new NorthwindContext();
        }

        public Customers FirstCustomer() 
        {
            var query = context.Customers.First();

            return query;
        }

        public List<Products> OutStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0).ToList();

            return query;

        }

        public List<Products> ProductsMoreExpensiveThan3()
        {
            var query = context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).ToList();

            return query;
            
        }

        public List<Customers> WACustomers()
        {
            var query = context.Customers.Where(c => c.Region == "WA").ToList();

            return query;   
        }

        public Products ProductFirstOrDefault()
        {
            var query = context.Products.FirstOrDefault(p => p.ProductID == 789);

            return query;      
        }

        public List<Customers> Customers()
        {
            var query = context.Customers.Select(c => c).ToList();

            return query;
            
        }

        public List<CustomersOrders> CustomersOrders()
        {
            var date = new DateTime(1997, 1, 1); 
            var query = from Customers in context.Customers
                        join Orders in context.Orders
                        on Customers.CustomerID
                        equals Orders.CustomerID
                        where(Customers.Region == "WA" && Orders.OrderDate > date)
                        select new CustomersOrders
                        {
                            CustomerName = Customers.ContactName,
                            OrderDate = (DateTime)Orders.OrderDate
                        };

            return query.ToList();

        }

        public List<Customers> WAFirst3()
        {
            var query = context.Customers.Where(c => c.Region == "WA")
                                         .Take(3)
                                         .ToList();
            return query;
        }

        public List<Products> ProductsOrderByName()
        {
            var query = context.Products.OrderBy(p => p.ProductName)
                                        .ToList();
            return query;
        }

        public List<Products> ProductsOrderByStock()
        {

            var query = context.Products.OrderByDescending(p => p.UnitsInStock)
                                        .ToList();
            return query;
        }

        public List<CategoryProduct> CategoryProducts()
        {
            var query = from Categories in context.Categories
                        join Products in context.Products
                        on Categories.CategoryID
                        equals Products.CategoryID
                        where (Categories.CategoryID == Products.CategoryID)
                        group Categories by Categories.CategoryName into c
                        select new CategoryProduct
                        {
                            CategoriesName = c.Key
                        };
           
            return query.ToList();
        }

        public Products FirstProduct()
        {
            var query = context.Products.First();
            return query;
        }

        public void Query13()
        {
            var query = from Orders in context.Orders
                        join Customers in context.Customers
                        on Orders.CustomerID
                        equals Customers.CustomerID
                        select new
                        {
                            CustomerName = Customers.ContactName,
                            Amount = Orders.CustomerID.Count()
                        };

           
                //Console.WriteLine($"{item.CustomerName} - {item.Amount}");
            

            //return query;
        }

    }
}
