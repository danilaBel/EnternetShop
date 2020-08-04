using EnternetShop.Application.Interfaces;
using EnternetShop.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnternetShop.Application.Commands.Characteristics.CreateCharacteristic
{
    public class CreateCharacteristicCommandHandle : IRequestHandler<CreateCharacteristicVm>
    {
        IEnternetShopDbContext context_;

        public CreateCharacteristicCommandHandle(IEnternetShopDbContext context_)
        {
            this.context_ = context_;
        }

        public async Task<Unit> Handle(CreateCharacteristicVm request, CancellationToken cancellationToken)
        {
            if (request.Name != null)
            {
                if (request.Value != null)
                {
                    var Characteristic = new Characteristic()
                    {
                        Name = request.Name,
                        Value = request.Value
                    };
                    await context_.Characteristics.AddAsync(Characteristic);
                    await context_.SaveChangesAsync(cancellationToken);
                }
            }
            return Unit.Value;
        }
    }
}
