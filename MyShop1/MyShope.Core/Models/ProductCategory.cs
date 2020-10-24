using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShope.Core.Models
{
    public class ProductCategory
    {
        public string Id;
        public string Category;

        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
