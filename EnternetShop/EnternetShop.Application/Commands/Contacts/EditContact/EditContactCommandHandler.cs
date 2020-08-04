using EnternetShop.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Contacts.EditContact
{
    public class EditContactCommandHandler : IRequestHandler<EditContactVm>
    {
        IEnternetShopDbContext context_;

        public EditContactCommandHandler(IEnternetShopDbContext context_)
        {
            this.context_ = context_;
        }

        public async Task<Unit> Handle(EditContactVm request, CancellationToken cancellationToken)
        {
            var oldContact = await context_.Сontacts.FindAsync(request.Id);

            if (oldContact != null)
            {
                oldContact.Name = request.Name;
                oldContact.Url = request.Url;

                context_.Сontacts.Update(oldContact);
                await context_.SaveChangesAsync(cancellationToken);
            }
            return Unit.Value;
        }
    }
}
