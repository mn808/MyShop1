using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShope.Core.Models
{
   public class Product
    {
        public string Id;

        [StringLength(20)]
        public string Name;
        public string Description;

        [Range(0, 1000)]
        public decimal Price;
        public string Category;
        public string Image;

        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
