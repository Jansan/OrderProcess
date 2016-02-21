using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcess.ViewModels
{
    public class DisplayProductsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Selected { get; set; }
        public SelectedDisplayProductsViewModel SelectedProducts { get; set; }


    }
}
