using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Characteristics.CreateCharacteristic
{
    public class CreateCharacteristicVm : IRequest
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
