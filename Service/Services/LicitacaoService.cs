using AutoMapper;
using Domain.Entities;
using Domain.Interface;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{    
    public class LicitacaoService : ILicitacaoService
	{
        private readonly ILicitacaoRepository _repository;
        private readonly IMapper _mapper;

        public LicitacaoService(ILicitacaoRepository repository, IMapper mapper)
        {
			_repository = repository;
            _mapper = mapper;
        }

		public async Task<IList<Licitacao>> GetBy(Licitacao item)
		{
            return await _repository.SelectBy(item);
        }
	}
}
