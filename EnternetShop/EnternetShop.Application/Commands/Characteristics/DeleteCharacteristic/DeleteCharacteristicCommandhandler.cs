using EnternetShop.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Characteristics.DeleteCharacteristic
{
    public class DeleteCharacteristicCommandhandler : IRequestHandler<DeleteCharacteristicVm>
    {
        IEnternetShopDbContext context_;

        public DeleteCharacteristicCommandhandler(IEnternetShopDbContext context_)
        {
            this.context_ = context_;
        }

        public async Task<Unit> Handle(DeleteCharacteristicVm request, CancellationToken cancellationToken)
        {
            var Characteristic = await context_.Characteristics.FindAsync(request.Name);

            if (Characteristic != null)
            {
                context_.Characteristics.Remove(Characteristic);
                await context_.SaveChangesAsync(cancellationToken);
            }
            return Unit.Value;
        }
    }
}
