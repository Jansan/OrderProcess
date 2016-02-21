using OrderProcess.ViewModels;
using System.Collections.Generic;

namespace OrderProcess.Models
{
    public interface IOrderProcessRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetById(int id);
        List<DisplayProductsViewModel> ListProducts();
        List<SelectedDisplayProductsViewModel> SelectedProducts(DisplayProductsViewModel dvm);
       // List<SelectedDisplayProductsViewModel> SelectedListProducts(DisplayProductsViewModel vm);
        void addProducts();
    }
}