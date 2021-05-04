using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLinq.Logic;
using TPLinq.Entities;

namespace TPLinq.Ui
{
    public class ShowQuerys
    {


        public void ShowCustomer(Customers customer)
        {
            Console.WriteLine($"{customer.CustomerID} - {customer.ContactName} - {customer.City}");
        }

        public void ShowCustomers(List<Customers> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.CustomerID} - {item.ContactName} - {item.City}");
            }
        }

        public void ShowCustomersNameUpper(List<Customers> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.ContactName.ToUpper()}");
            }
            
        }

        public void ShowCustomersNameLower(List<Customers> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.ContactName.ToLower()}");
            }

        }

        public void ShowProduct(Products product)
        {
            try
            {
                Console.WriteLine($"{product.ProductID} - {product.ProductName}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("ID nulo");
            }
            
        }

        public void ShowProducts(List<Products> products) 
        {
            foreach (var item in products)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName}");
            }
        }

        public void ShowCustomersOrders(List<CustomersOrders> customersOrders)
        {
            foreach (var item in customersOrders)
            {
                Console.WriteLine($"{item.CustomerName} - {item.OrderDate}");
            }
        }

        public void ShowCategoryProduct(List<CategoryProduct> categoryProducts)
        {
            foreach (var item in categoryProducts)
            {
                Console.WriteLine($"{item.CategoriesName}");
            }
        }
        

    }
}
