using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnternetShop.Domain.Entity
{
    public class Сontact
    {
        [Key]
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser{get;set;}
    }
}
