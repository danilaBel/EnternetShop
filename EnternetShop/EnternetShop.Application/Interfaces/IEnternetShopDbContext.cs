﻿using EnternetShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EnternetShop.Application.Interfaces
{
    public interface IEnternetShopDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Characteristic> Characteristics { get; set; }
        DbSet<Subcategory> Subcategories { get; set; }
        DbSet<Сontact> Сontacts { get; set; }
        DbSet<Product> Products { get; set; }

        public void SaveChangesAsync(CancellationToken cn);
    }
}
