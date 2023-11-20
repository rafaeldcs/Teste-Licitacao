using Domain.Entities;
using FluentValidation;

namespace Service.Validator
{
    public class LicitacaoValidator : AbstractValidator<Licitacao>
    {
        public LicitacaoValidator()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor preencha a Descricao.")
                .NotNull().WithMessage("Por favor preencha a Descricao.");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("Por favor preencha o número.")
                .NotNull().WithMessage("Por favor preencha a número.");

            RuleFor(c => c.DataAbertura)
                .NotEmpty().WithMessage("Por favor preencha a DataAbertura.")
                .NotNull().WithMessage("Por favor preencha a DataAbertura.");

            RuleFor(c => c.status)
                .NotEmpty().WithMessage("Por favor preencha o Status.")
                .NotNull().WithMessage("Por favor preencha o Status.");
        }
    }
}