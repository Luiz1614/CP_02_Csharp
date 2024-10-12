using CP2.API.Domain.Entities;

namespace CP2.API.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        void Adicionar(VendedorEntity vendedor);
        void Atualizar(VendedorEntity vendedor);
        void Deletar(VendedorEntity vendedor);
        VendedorEntity ObterPorId(int id);
        VendedorEntity ObterTodos();
    }
}
