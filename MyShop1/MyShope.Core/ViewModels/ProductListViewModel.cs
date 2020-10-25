using MyShope.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShope.Core.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products;
        public IEnumerable<ProductCategory> ProductCategories;
    }
}
