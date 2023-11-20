using ApiControle.Model;
using Domain.Entities;
using Domain.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Validator;
using System;

namespace ApiControle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        /*private IBaseService<TObject> _service;

        public BaseController(IBaseService<TObject> service)
        {
            _service = service;
        }*/

		#region EndPoints
		//End Point de salvar
		/*[HttpPost]
        public IActionResult Create<Tinput,ToutPut,Tvalidator>([FromBody] object model)
        {
            if (model == null)
                return NotFound();

            return Execute(() => _service.Add<object, ToutPut, Tvalidator>(model));
        }

        //End Point de atualizar (caso necessário)
        [HttpPut]
        public IActionResult Update([FromBody] LicitacaoModel model)
        {
            if (model == null)
                return NotFound();

            return Execute(() => _service.Update<LicitacaoModel, Licitacao, LicitacaoValidator>(model));
        }

        //End Point de excluir(caso necessário)
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _service.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        //End Point de busca(caso necessário)
        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _service.Get<Licitacao>());
        }

        //End Point de busca por ID(caso necessário)
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _service.GetById<Licitacao>(id));
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
        }*/
		#endregion
	}
}