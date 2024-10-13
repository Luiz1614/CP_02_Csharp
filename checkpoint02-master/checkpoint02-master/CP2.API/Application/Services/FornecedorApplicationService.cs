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

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.ObterTodos();
        }

        public void AdicionarFornecedor(FornecedorDto fornecedorDto)
        {
            var fornecedorEntity = new FornecedorEntity()
            {
                Nome = fornecedorDto.Nome,
                CNPJ = fornecedorDto.CNPJ,
                Telefone = fornecedorDto.Telefone,
                Email = fornecedorDto.Email,
                Endereco = fornecedorDto.Endereco,
                
            };

            _repository.Adicionar(fornecedorEntity);
        }

        public void AtualizarFornecedor(int id, FornecedorDto fornecedorDto)
        {
            var fornecedorEntity = new FornecedorEntity()
            {
                Nome = fornecedorDto.Nome,
                CNPJ = fornecedorDto.CNPJ,
                Telefone = fornecedorDto.Telefone,
                Email = fornecedorDto.Email,
                Endereco = fornecedorDto.Endereco,
            };

            _repository.Atualizar(id, fornecedorEntity);
        }

        public void DeletarFornecedor(int id)
        {
            _repository.Deletar(id);
        }
    }
}
