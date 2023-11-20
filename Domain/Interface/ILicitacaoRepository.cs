using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ILicitacaoRepository
    {
        Task<IList<Licitacao>> SelectBy(Licitacao item);        
    }
}
