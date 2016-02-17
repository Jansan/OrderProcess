using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcess.ViewModels;

namespace OrderProcess.Models
{

    public interface IOrderRepository
    {
        ListOrderViewModel[] GetAll();
    }


    public class OrderDBRepository : IOrderRepository
    {
        OrderContext _context;

        public OrderDBRepository(OrderContext context)
        {
            _context = context;
        }

        public ListOrderViewModel[] GetAll()
        {
            return _context.Orders
                .Select(c => new ListOrderViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price
                })
                .ToArray();
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
        }
    }
}
