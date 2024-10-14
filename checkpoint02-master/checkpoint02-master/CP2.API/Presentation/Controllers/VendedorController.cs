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
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorApplicationService _applicationService;

        public VendedorController(IVendedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "Lista todos os vendedores", Description = "Este endpoint retorna uma lista completa de todos os vendedores cadastrados.")]
        [Produces<IEnumerable<VendedorEntity>>]
        public IActionResult Get()
        {
            try
            {
                var vendedores = _applicationService.ObterTodosVendedores();
                if (vendedores == null)
                {
                    return NoContent();
                }
                return Ok(vendedores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtém um vendedor por ID", Description = "Este endpoint retorna um vendedor específico por ID.")]
        [Produces<VendedorEntity>]
        public IActionResult GetPorId(int id)
        {
            try
            {
                var vendedor = _applicationService.ObterVendedorPorId(id);

                if (vendedor == null)
                    return NoContent();

                return Ok(vendedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [SwaggerOperation(Summary = "Adiciona um novo vendedor", Description = "Este endpoint adiciona um novo vendedor.")]
        [Produces<VendedorEntity>]
        public IActionResult Post([FromBody] VendedorDto entity)
        {
            try
            {
                _applicationService.AdicionarVendedor(entity);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atualiza um vendedor", Description = "Este endpoint atualiza um vendedor.")]
        [Produces<VendedorEntity>]
        public IActionResult Put(int id, [FromBody] VendedorDto entity)
        {
            try
            {
                _applicationService.AtualizarVendedor(id, entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Deleta um vendedor", Description = "Este endpoint deleta um vendedor.")]
        [Produces<VendedorEntity>]
        public IActionResult Delete(int id)
        {
            try
            {
                _applicationService.DeletarVendedor(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
