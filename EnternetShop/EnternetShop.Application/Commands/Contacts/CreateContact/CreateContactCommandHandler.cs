using EnternetShop.Application.Interfaces;
using EnternetShop.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Contacts.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactVm>
    {
        IEnternetShopDbContext context_;
        UserManager<AppUser> manager_;

        public CreateContactCommandHandler(IEnternetShopDbContext context_, UserManager<AppUser> manager_)
        {
            this.context_ = context_;
            this.manager_ = manager_;
        }

        public async Task<Unit> Handle(CreateContactVm request, CancellationToken cancellationToken)
        {
            var User = await manager_.FindByIdAsync(request.AppUserId);
            if (User != null)
            {
                var Contact = new Сontact()
                {
                    AppUser = User,
                    AppUserId = User.Id,
                    Name = request.Name,
                    Url = request.Url
                };
                await context_.Сontacts.AddAsync(Contact);
                await context_.SaveChangesAsync(cancellationToken);
            }
            
            return Unit.Value;
        }
    }
}
