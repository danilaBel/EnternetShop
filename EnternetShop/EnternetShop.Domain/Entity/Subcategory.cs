using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnternetShop.Domain.Entity
{
    public class Subcategory
    {
        [Key]
        public string Id { get; set; }

        public Category Category { get; set; }

        public string CategoryId { get; set; }
        string Name { get; set; }
        public IEnumerable<string> words { get; set; } 
    }
}
