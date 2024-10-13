using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CP2.API.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;
        private readonly Mappings.MapperProfile _mapper;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity AdicionarFornecedor(FornecedorDto fornecedorDto)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity AtualizarFornecedor(int id, FornecedorDto fornecedorDto)
        {
            throw new NotImplementedException();
        }

        public void DeletarFornecedor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
