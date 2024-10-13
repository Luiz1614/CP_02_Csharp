using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;

namespace CP2.API.Application.Interfaces
{
    public interface IFornecedorApplicationService
    {
        FornecedorEntity? ObterFornecedorPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodosFornecedores();
        FornecedorEntity AdicionarFornecedor(FornecedorDto fornecedorDto);
        FornecedorEntity AtualizarFornecedor(int id, FornecedorDto fornecedorDto);
        void DeletarFornecedor(int id);
    }
}
