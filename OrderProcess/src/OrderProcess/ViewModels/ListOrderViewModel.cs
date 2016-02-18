using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcess.ViewModels
{
    public class ListOrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Vara")]
        public string Name { get; set; }

        [Display(Name = "Pris")]
        public int Price { get; set; }

        public string Details { get; set; }

    }
}
