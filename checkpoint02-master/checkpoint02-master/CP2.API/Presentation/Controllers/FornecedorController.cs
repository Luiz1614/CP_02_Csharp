using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace CP2.API.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorApplicationService _applicationService;

        public FornecedorController(IFornecedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "Lista todos os fornecedores", Description = "Este endpoint retorna uma lista completa de todos os fornecedores cadastrados.")]
        [Produces<IEnumerable<FornecedorEntity>>]
        public IActionResult Get()
        {
            try
            {
                var fornecedores = _applicationService.ObterTodosFornecedores();

                if (fornecedores == null)
                    return NoContent();
                return Ok(fornecedores);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtém um fornecedor por ID", Description = "Este endpoint retorna um fornecedor específico por ID.")]
        [Produces<FornecedorEntity>]
        public IActionResult GetPorId(int id)
        {
            try
            {
                var fornecedor = _applicationService.ObterFornecedorPorId(id);

                if (fornecedor == null)
                    return NoContent();
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [SwaggerOperation(Summary = "Adiciona um novo fornecedor", Description = "Este endpoint adiciona um novo fornecedor.")]
        [Produces<FornecedorEntity>]
        public IActionResult Post([FromBody] FornecedorDto entity)
        {
            try
            {
                _applicationService.AdicionarFornecedor(entity);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atualiza um fornecedor", Description = "Este endpoint atualiza um fornecedor.")]
        [Produces<FornecedorEntity>]
        public IActionResult Put(int id, [FromBody] FornecedorDto entity)
        {
            try
            {
                _applicationService.AtualizarFornecedor(id, entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Deleta um fornecedor", Description = "Este endpoint deleta um fornecedor.")]
        [Produces<FornecedorEntity>]
        public IActionResult Delete(int id)
        {
            try
            {
                _applicationService.DeletarFornecedor(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }
    }
}
