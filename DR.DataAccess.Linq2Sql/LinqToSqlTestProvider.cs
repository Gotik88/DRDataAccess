using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using DR.DataAccess.Test.Framework;

namespace DR.DataAccess.Linq2Sql
{
    public class LinqToSqlTestProvider : BaseTestProvider, ITestProvider
    {
        private readonly NorthwindDataContext _context;

        public LinqToSqlTestProvider(NorthwindDataContext context)
            : base(context)
        {
            _context = context;
        }

        public IList GetOrders()
        {
            return _context.Orders.ToList();
        }

        public IList GetCustomerProducts(string customerId)
        {
            var allProductsData = (from cust in _context.Customers
                                   where cust.CustomerID == customerId
                                   select new
                                   {
                                       Orders = from ord in cust.Orders
                                                select new
                                                {
                                                    Products = from det in ord.Order_Details select det.Product
                                                }
                                   }).ToList();

            var products = new List<Product>();
            var productsData = allProductsData.FirstOrDefault();
            if (productsData != null)
            {
                foreach (var ordersData in productsData.Orders)
                {
                    foreach (Product product in ordersData.Products)
                    {
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public IList GetCustomerProductsComplex(string customerId)
        {
            var orders =
                (from cust in _context.Customers
                 where cust.CustomerID == customerId
                 select cust.Orders).FirstOrDefault();

            if (orders == null)
                return new List<Product>();

            var products = new List<Product>();
            foreach (Order order in orders)
            {
                foreach (Order_Detail details in order.Order_Details)
                {
                    products.Add(details.Product);
                }
            }

            return products;
        }

        public void ModifyCustomers()
        {
            throw new System.NotImplementedException();
        }
    }
}
