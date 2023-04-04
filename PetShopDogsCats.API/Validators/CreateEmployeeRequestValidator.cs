﻿using Application.Contracts.Request;
using FluentValidation;


namespace PetShopDogsCats.API.Validators
{
    public class CreateEmployeeRequestValidator : AbstractValidator<CreateEmployeeRequest>
    {
        public CreateEmployeeRequestValidator()
        {
            RuleFor(model => model.Name).NotEmpty()
                .WithMessage("O nome do empregado é obrigatório");
            
            RuleFor(model => model.Cpf).NotEmpty()
                .WithMessage("O CPF do empregado é obrigatório");
            
            RuleFor(model => model.Rg).NotEmpty()
                .WithMessage("O RG do empregado é obrigatório");

            RuleFor(model => model.Email)
                .NotEmpty().WithMessage("O email do empregado é obrigatório")
                .MaximumLength(100).WithMessage("O email não pode ultrapassar a 100 caracteres")
                .EmailAddress().WithMessage("O email informado não tem um formato válido");

            RuleFor(model => model.CellPhone).NotEmpty()
                .WithMessage("O celular do empregado é obrigatório");
            
            RuleFor(model => model.AdmissionDate).NotEmpty()
                .WithMessage("A data de admissão do empregado é obrigatório");

            RuleFor(model => model.Gender).NotEmpty()
                .WithMessage("Informar o gênero do empregado é obrigatório.");
            
            RuleFor(model => model.Address).SetValidator(new CreateAddressRequestValidator());
        }
    }
}
