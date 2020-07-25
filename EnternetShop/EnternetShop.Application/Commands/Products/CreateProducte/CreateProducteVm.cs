using EnternetShop.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Products.CreateProducte
{
    public class CreateProducteVm:IRequest
    {
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string AppUserId { get; set; }

        public double Price { get; set; }

        public string Picture { get; set; }

        public Availability Availability { get; set; }
    }
}
