﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.Common.Features.Users.Commands.LoginUser;
using FluentValidation;

namespace Dictionary.Application.Features.Users.Commands.Login
{
    public sealed class LoginUserCommandValidator:AbstractValidator<LoginUserCommandRequest>
    {
        public LoginUserCommandValidator()
        {
            RuleFor(e => e.Email).NotNull().EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("{PropertyName} not a valid e-mail address!");

            RuleFor(e => e.Password).NotNull().MinimumLength(6).WithMessage("{PropertyName} should at least be {MinLength} character");
        }
    }
}
