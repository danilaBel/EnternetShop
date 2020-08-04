using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Contacts.EditContact
{
    public class EditContactVm : IRequest
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Name { get; set; }
    }
}
