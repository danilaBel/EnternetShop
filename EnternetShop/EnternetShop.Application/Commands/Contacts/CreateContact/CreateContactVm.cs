using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnternetShop.Application.Commands.Contacts.CreateContact
{
    public class CreateContactVm : IRequest
    {
        public string Url { get; set; }

        public string Name { get; set; }

        public string AppUserId { get; set; }
    }
}
