using Microsoft.AspNet.Mvc;
using OrderProcess.Models;
using OrderProcess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcess.Views.Shared.Components.SelectedProductList
{
    public class SelectedProductListViewComponent : ViewComponent
    {
        private IOrderProcessRepository _repository;

        public SelectedProductListViewComponent(IOrderProcessRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            
            var products = _repository.ListProducts().Where(p => p.Selected == true);
            return View(products);
            
            //    var car = DataManager.ListCars().Where(x => x.ShowAsFast == true && x.TopSpeed >= fastestCars);
            //return View(car);
        }
    }
}
