using OrderProcess.ViewModels;
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
            Product product = _context.Products.Where(p =>p.Id ==id).Single();
            return product;
        }

        //All Products
        public List<DisplayProductsViewModel> ListProducts()
        {
            List<DisplayProductsViewModel> listOfProducts = new List<DisplayProductsViewModel>();
            foreach(var item in _context.Products)
            {
                
                DisplayProductsViewModel product = new DisplayProductsViewModel();
               
                    product.Name = item.Name;
                    product.Price = item.Price;
                    listOfProducts.Add(product);
               
                               

            }
            return listOfProducts;
        }

        public List<SelectedDisplayProductsViewModel> SelectedProducts(DisplayProductsViewModel dvm)
        {
            SelectedDisplayProductsViewModel selectedProduct = new SelectedDisplayProductsViewModel();
            List<SelectedDisplayProductsViewModel> selectedList = new List<SelectedDisplayProductsViewModel>();
            if(dvm.Selected == true)
            {
                
                dvm.Name = selectedProduct.Name;
                dvm.Price = selectedProduct.Price;
                selectedList.Add(selectedProduct);
            }
            return selectedList;
        }

        ////selected products
        //public List<SelectedDisplayProductsViewModel> SelectedListProducts(List<DisplayProductsViewModel> vm)
        //{
        //    List<SelectedDisplayProductsViewModel> selectedListOfProducts = new List<SelectedDisplayProductsViewModel>();

        //    SelectedDisplayProductsViewModel SelectedProduct = new SelectedDisplayProductsViewModel();

        //    if (vm.Selected == true)
        //    {
        //        SelectedProduct.Name = vm.Name;
        //        SelectedProduct.Price = vm.Price;
        //        selectedListOfProducts.Add(SelectedProduct);
        //    }

        //    return selectedListOfProducts;
        //}



        //Add Products
        public void addProducts()
        {

        }
    }
}
