using ApiControle.Model;
using AutoMapper;
using Domain.Entities;
using Domain.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using Service.Validator;
using System;

namespace ApiControle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicitacaoController : ControllerBase
    {
        private IBaseService<Licitacao> _BaseService;
        private ILicitacaoService _service;
		private readonly IMapper _mapper;

		public LicitacaoController(IBaseService<Licitacao> BaseService, ILicitacaoService service,
            IMapper mapper)
        {
			_BaseService = BaseService;
            _service = service;
            _mapper = mapper;
        }

		#region EndPoints
		//End Point de salvar
		[HttpPost]
        public IActionResult Create([FromBody] LicitacaoModel model)
        {
            if (model == null)
                return NotFound();

            return Execute(() => _BaseService.Add<LicitacaoModel, Licitacao, LicitacaoValidator>(model));
        }

        //End Point de atualizar (caso necessário)
        [HttpPut]
        public IActionResult Update([FromBody] LicitacaoModel model)
        {
            if (model == null)
                return NotFound();

            return Execute(() => _BaseService.Update<LicitacaoModel, Licitacao, LicitacaoValidator>(model));
        }

        //End Point de excluir(caso necessário)
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id == default)
                return NotFound();

            Execute(() =>
            {
				_BaseService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        //End Point de busca(caso necessário)
        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _BaseService.Get<Licitacao>());
        }

        //End Point de busca(caso necessário)
        [HttpGet,Route("Buscar")]
        public async Task<IActionResult> GetBy([FromQuery]LicitacaoModel model)
        {
            try
            {
                var modelo = _mapper.Map<Licitacao>(model);

				return Ok(await _service.GetBy(modelo));
            }
            catch(Exception ex)
            {
				return BadRequest(ex);
			}            
        }

        //End Point de busca por ID(caso necessário)
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (id == default)
                return NotFound();

            return Execute(() => _BaseService.GetById<Licitacao>(id));
        }

        //Função para Executar busca nos service
        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
		#endregion
	}
}