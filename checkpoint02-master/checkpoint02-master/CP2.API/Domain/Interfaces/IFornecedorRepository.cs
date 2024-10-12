using CP2.API.Domain.Entities;

namespace CP2.API.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        void Adicionar(FornecedorEntity fornecedor);
        void Atualizar(FornecedorEntity fornecedor);
        void Deletar(FornecedorEntity fornecedor);
        FornecedorEntity ObterPorId(int id);
        FornecedorEntity ObterTodos();
    }
}
