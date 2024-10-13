using CP2.API.Domain.Entities;

namespace CP2.API.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        void Adicionar(FornecedorEntity fornecedor);
        void Atualizar(int id, FornecedorEntity fornecedor);
        void Deletar(int id);
        FornecedorEntity ObterPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodos();
    }
}
