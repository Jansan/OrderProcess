using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using OrderProcess.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderProcess.Controllers
{
    public class OrderController : Controller
    {
        IOrderReposetory _reposetory;

        public OrderController( IOrderReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public IActionResult Index()
        {
            return View(_reposetory.GetAll());
        }
    }
}
