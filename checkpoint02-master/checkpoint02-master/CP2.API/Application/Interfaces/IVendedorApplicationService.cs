using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;

namespace CP2.API.Application.Interfaces
{
    public interface IVendedorApplicationService
    {
        VendedorEntity? ObterVendedorPorId(int id);
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        VendedorEntity AdicionarVendedor(VendedorDto vendedorDto);
        VendedorEntity AtualizarVendedor(int id, VendedorDto vendedorDto);
        void DeletarVendedor(int id);
    }
}
