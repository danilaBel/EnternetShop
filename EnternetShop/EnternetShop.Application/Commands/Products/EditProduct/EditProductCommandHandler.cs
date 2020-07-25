using EnternetShop.Application.Interfaces;
using EnternetShop.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Products.EditProducte
{
    public class EditProductCommandHandler : IRequestHandler<EditProductVm>
    {
        IEnternetShopDbContext context_;

        public async Task<Unit> Handle(EditProductVm request, CancellationToken cancellationToken)
        {
            var Category = await context_.Categories.FindAsync(request.CategoryName);
            var oldProduct = await context_.Products.FindAsync(request.Id);

            if (oldProduct!=null)
            {
                if (Category!=null)
                {
                    oldProduct.Name = request.Name;
                    oldProduct.Category = Category;
                    oldProduct.Description = request.Description;
                    oldProduct.Price = request.Price;
                    oldProduct.Picture = request.Picture;
                    oldProduct.Availability = request.Availability;

                    context_.Products.Update(oldProduct);
                    await context_.SaveChangesAsync(cancellationToken);
                }
            }
            return Unit.Value;
        }
    }
}
