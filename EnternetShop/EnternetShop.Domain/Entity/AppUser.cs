using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Domain.Entity
{
    public class AppUser: IdentityUser<string>
    {
        public string Photo { get; set; }

        public IEquatable<Сontact> Contacts { get; set; }
    }
}
