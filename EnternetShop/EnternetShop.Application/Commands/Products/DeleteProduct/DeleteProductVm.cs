using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Products.DeleteProduct
{
    public class DeleteProductVm : IRequest
    {
        public string Id { get; set; }
    }
}
