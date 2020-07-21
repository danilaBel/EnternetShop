using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnternetShop.Domain.Entity
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string Description { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser {get;set;}

        public double Price { get; set; }

        public string Picture { get; set; }

        public Availability Availability { get; set; }
    }
}
