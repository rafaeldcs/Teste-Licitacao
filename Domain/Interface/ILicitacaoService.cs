using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ILicitacaoService
    {
        Task<IList<Licitacao>> GetBy(Licitacao item);
    }
}
