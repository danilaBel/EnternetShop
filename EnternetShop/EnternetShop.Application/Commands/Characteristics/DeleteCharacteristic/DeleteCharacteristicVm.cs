using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Characteristics.DeleteCharacteristic
{
    public class DeleteCharacteristicVm : IRequest
    {
        public string Name { get; set; }
    }
}
