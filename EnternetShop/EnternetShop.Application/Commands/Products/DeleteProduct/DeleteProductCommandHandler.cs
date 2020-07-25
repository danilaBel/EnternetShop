using EnternetShop.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Products.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductVm>
    {
        IEnternetShopDbContext context_;

        public DeleteProductCommandHandler(IEnternetShopDbContext context_)
        {
            this.context_ = context_;
        }

        public async Task<Unit> Handle(DeleteProductVm request, CancellationToken cancellationToken)
        {
            var Product = await context_.Products.FindAsync(request.Id);

            if (Product!=null)
            {
                context_.Products.Remove(Product);
                await context_.SaveChangesAsync(cancellationToken);
            }
            return Unit.Value;
        }
    }
}
