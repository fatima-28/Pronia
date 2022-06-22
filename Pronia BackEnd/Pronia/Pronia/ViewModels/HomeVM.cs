using Pronia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.ViewModels
{
    public class HomeVM
    {
        public List<Slide> Slides { get; set; }
        public List<Summary> Summary { get; set; }
        public List<Futures> Futures { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
