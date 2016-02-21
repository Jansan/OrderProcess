using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using OrderProcess.Models;
using OrderProcess.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderProcess.Controllers
{
    public class ProductsController : Controller
    {
        private IOrderProcessRepository _repository;

        public ProductsController(IOrderProcessRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var products = _repository.ListProducts();
            return View(products);
        }

        public IActionResult Add()
        {
            
            return View();

        }

        [HttpPost]
        public IActionResult Add(DisplayProductsViewModel vm)
        {

            _repository.SelectedProducts(vm);            
           
            return PartialView("SelectedProducts");

        }
    }
}
