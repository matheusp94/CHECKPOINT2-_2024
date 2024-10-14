using CP2.Domain.Interfaces.Dtos;
using FluentValidation;
using System;
using System.Linq;

namespace CP2.Application.Dtos
{
    public class VendedorDto : IVendedorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validateResult = new VendedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class VendedorDtoValidation : AbstractValidator<VendedorDto>
    {
        public VendedorDtoValidation()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome do vendedor é obrigatório.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O email é obrigatório.")
                .EmailAddress().WithMessage("O email deve ser válido.");

            RuleFor(x => x.Telefone)
                .NotEmpty().WithMessage("O telefone é obrigatório.");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("A data de nascimento é obrigatória.")
                .LessThan(DateTime.Now).WithMessage("A data de nascimento deve ser anterior à data atual.");

            RuleFor(x => x.Endereco)
                .NotEmpty().WithMessage("O endereço é obrigatório.");

            RuleFor(x => x.DataContratacao)
                .NotEmpty().WithMessage("A data de contratação é obrigatória.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data de contratação deve ser anterior ou igual à data atual.");

            RuleFor(x => x.ComissaoPercentual)
                .InclusiveBetween(0, 100).WithMessage("O percentual de comissão deve estar entre 0 e 100.");

            RuleFor(x => x.MetaMensal)
                .GreaterThan(0).WithMessage("A meta mensal deve ser maior que zero.");
        }
    }
}
