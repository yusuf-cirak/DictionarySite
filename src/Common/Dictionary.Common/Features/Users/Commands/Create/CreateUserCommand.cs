﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Dictionary.Common.Features.Users.Commands.CreateUser
{
    public sealed class CreateUserCommandRequest : IRequest<Guid>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }

}
