﻿using Application.Contracts.Request;
using FluentValidation;

namespace PetShopDogsCats.API.Validators
{
    public class CreateAddressRequestValidator : AbstractValidator<CreateAddressRequest?>
    {
        public CreateAddressRequestValidator()
        {
            RuleFor(model => model!.ZipCode).NotEmpty().WithMessage("O CEP do endereço é obrigatório");
            RuleFor(model => model!.StreetAddress).NotEmpty().WithMessage("O logradouro do endereço é obrigatório");
            RuleFor(model => model!.Number).NotEmpty().WithMessage("O número do endereço é obrigatório");            
            RuleFor(model => model!.Neighborhood).NotEmpty().WithMessage("O bairro do endereço é obrigatório");
            RuleFor(model => model!.City).NotEmpty().WithMessage("A cidade do endereço é obrigatório");
            RuleFor(model => model!.State).NotEmpty().WithMessage("O estado do endereço é obrigatório");
            // RuleFor(model => model!.Country).NotEmpty().WithMessage("O pais do endereço é obrigatório");
        }
    }
}
