using System.Collections.Generic;

namespace OrderProcess.Models
{
    public interface IOrderProcessRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetById(int id);
        void addProducts();
    }
}