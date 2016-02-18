using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcess.Models
{
    public class OrderProcessRepository : IOrderProcessRepository
    {
        private OrderContext _context;

        public OrderProcessRepository(OrderContext context)
        {
            _context = context;
        }

        //GetALL method
        public IEnumerable<Product> GetAllProduct()
        {
            var products = _context.Products.ToList();
            return products;
        }

        //GetbyId
        public Product GetById(int id)
        {
            var product = _context.Products.Where(p =>p.Id ==id).Single();
            return product;
        }
        //Add Products
        public void addProducts()
        {

        }
    }
}
