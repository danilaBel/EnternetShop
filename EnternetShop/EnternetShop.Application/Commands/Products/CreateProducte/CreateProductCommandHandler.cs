using EnternetShop.Application.Interfaces;
using EnternetShop.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Products.CreateProducte
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProducteVm>
    {
        IEnternetShopDbContext context_;
        UserManager<AppUser> manager_;

        public CreateProductCommandHandler(IEnternetShopDbContext context_, UserManager<AppUser> manager_)
        {
            this.context_ = context_;
            this.manager_ = manager_;
        }

        public async Task<Unit> Handle(CreateProducteVm request, CancellationToken cancellationToken)
        {
            var Category = await context_.Categories.FindAsync(request.CategoryName);
            var User = await manager_.FindByIdAsync(request.AppUserId);
            if (Category!=null)
            {
                if (User!=null)
                {
                    var Product = new Product()
                    {
                        AppUser = User,
                        AppUserId = User.Id,
                        CategoryId = Category.Id,
                        Name = request.Name,
                        Picture = request.Picture,
                        Price = request.Price,
                        Description = request.Description,
                        Category = Category,
                        Availability = request.Availability
                    };
                    await context_.Products.AddAsync(Product);
                    await context_.SaveChangesAsync(cancellationToken);
                }
            }
            return Unit.Value;
        }
    }
}
