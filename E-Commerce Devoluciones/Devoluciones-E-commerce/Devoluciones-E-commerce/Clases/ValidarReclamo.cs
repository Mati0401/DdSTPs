using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Devoluciones_E_commerce
{
    internal class ValidarReclamo : AbstractValidator<Reclamo>
    {
        public ValidarReclamo()
        {

            RuleFor(x => x.Tipo).NotEmpty().WithMessage("No puede dejar el campo Tipo vacío.");

            RuleFor(x => x.Motivo).NotEmpty().WithMessage("No puede dejar el campo Motivo vacío.");

            RuleFor(x => x.Descripcion).MinimumLength(20).WithMessage("La descripción debe tener al menos 20 caracteres.").
            MaximumLength(500).WithMessage("La descripción no puede tener más de 500 caracteres.");
            
        }

    }
}
