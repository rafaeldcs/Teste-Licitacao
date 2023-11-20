using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class LicitacaoRepository : ILicitacaoRepository
    {
        protected readonly Context.DbContext _context;

        public LicitacaoRepository(Context.DbContext context)
        {
            _context = context;
        }

		public async Task<IList<Licitacao>> SelectBy(Licitacao item)
		{
            var query = _context.Licitacao.AsNoTracking();

            if (item.status != default)
                query.Where(x => x.status == item.status);

            if (!string.IsNullOrEmpty(item.Numero))
                query.Where(x => x.Numero.Contains(item.Numero));

            if (!string.IsNullOrEmpty(item.Descricao))
                query.Where(x => x.Numero.Contains(item.Numero));

            if (item.DataAbertura != default)
                query.Where(x => x.status == item.status);

			return await query.ToListAsync();
		}
	}
}
