using EnternetShop.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Contacts.DeleteContact
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactVm>
    {
        IEnternetShopDbContext context_;

        public DeleteContactCommandHandler(IEnternetShopDbContext context_)
        {
            this.context_ = context_;
        }

        public async Task<Unit> Handle(DeleteContactVm request, CancellationToken cancellationToken)
        {
            var Contact = await context_.Сontacts.FindAsync(request.Id);

            if (Contact != null)
            {
                context_.Сontacts.Remove(Contact);
                await context_.SaveChangesAsync(cancellationToken);
            }
            return Unit.Value;
        }
    }
}
