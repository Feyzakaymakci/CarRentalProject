﻿using Core.Entities.Concrete;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u=>u.FirstName).NotEmpty();
            RuleFor(u=>u.LastName).NotEmpty();
            RuleFor(u=>u.Email).NotEmpty();
            RuleFor(u=>u.FirstName).NotNull();
            RuleFor(u=>u.LastName).NotNull();
            RuleFor(u=>u.Email).NotNull();

        }
    }
}
