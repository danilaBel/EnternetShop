using EnternetShop.Domain;
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
        DbSet<Filter> Filters { get; set; }
        DbSet<Product> Products { get; set; }

        public void SaveChangesAsync(CancellationToken cn);
    }
}
