﻿using MyShope.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base("DefaultConnection")
        {

        }

        public DbSet<Product> Products;
        public DbSet<ProductCategory> ProductsCategories;
        public DbSet<Basket> Baskets;
        public DbSet<BasketItem> BasketItems;

    }
}
