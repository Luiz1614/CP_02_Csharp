using CP2.API.Domain.Entities;

namespace CP2.API.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        void Adicionar(VendedorEntity vendedor);
        void Atualizar(int id, VendedorEntity vendedor);
        void Deletar(int id);
        VendedorEntity ObterPorId(int id);
        IEnumerable<VendedorEntity> ObterTodos();
    }
}
