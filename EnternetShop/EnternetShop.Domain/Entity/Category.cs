using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnternetShop.Domain.Entity
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        [Key]
        public string Name { get; set; }

        public IEnumerable<Subcategory> Subcategories { get; set; }

        public IEnumerable<Characteristic> Characteristics { get; set; }
    }
}
