﻿using FluentValidation;
using Papara.NET.Bootcamp.Models.DTOs;

namespace Papara.NET.Bootcamp.Validations
{
    public class AuthorCreateValidator : AbstractValidator<AuthorCreateDto>
    {
        public AuthorCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.BirthDate).LessThan(DateTime.Now);
        }
    }
}
