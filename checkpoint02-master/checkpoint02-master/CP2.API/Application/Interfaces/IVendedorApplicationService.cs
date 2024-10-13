using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;

namespace CP2.API.Application.Interfaces
{
    public interface IVendedorApplicationService
    {
        VendedorEntity? ObterVendedorPorId(int id);
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        void AdicionarVendedor(VendedorDto vendedorDto);
        void AtualizarVendedor(int id, VendedorDto vendedorDto);
        void DeletarVendedor(int id);
    }
}
