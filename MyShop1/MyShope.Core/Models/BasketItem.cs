﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShope.Core.Models
{
   public class BasketItem : BaseEntity
    {
        public string BasketId;
        public string ProductId;
        public int Quantity;
    }
}
