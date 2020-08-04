using EnternetShop.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Characteristics.EditCharacteristic
{
    public class EditCharacteristicCommandHandler : IRequestHandler<EditCharacteristicVm>
    {
        IEnternetShopDbContext context_;

        public EditCharacteristicCommandHandler(IEnternetShopDbContext context_)
        {
            this.context_ = context_;
        }

        public async Task<Unit> Handle(EditCharacteristicVm request, CancellationToken cancellationToken)
        {
            var oldCharacteristic = await context_.Characteristics.FindAsync(request.Name);

            if (oldCharacteristic != null)
            {
                oldCharacteristic.Name = request.Name;
                oldCharacteristic.Value = request.Value;

                context_.Characteristics.Update(oldCharacteristic);
                await context_.SaveChangesAsync(cancellationToken);
            }
            return Unit.Value;
        }
    }
}
