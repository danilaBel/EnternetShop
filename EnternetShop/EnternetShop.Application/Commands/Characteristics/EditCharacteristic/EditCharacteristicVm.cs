using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Characteristics.EditCharacteristic
{
    public class EditCharacteristicVm : IRequest
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
