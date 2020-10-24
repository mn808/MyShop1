using MyShope.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShope.Core.View_Models
{
   public class ProductManagerViewModel
    {
        public Product Product;
        public IEnumerable<ProductCategory> ProductCategories;
    }
}
