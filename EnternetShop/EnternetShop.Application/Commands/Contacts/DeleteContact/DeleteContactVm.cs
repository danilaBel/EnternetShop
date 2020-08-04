using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Contacts.DeleteContact
{
    public class DeleteContactVm : IRequest
    {
        public string Id { get; set; }
    }
}
