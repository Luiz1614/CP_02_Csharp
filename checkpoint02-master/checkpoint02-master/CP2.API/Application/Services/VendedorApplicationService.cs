using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            return _repository.ObterTodos();
        }

        public void AdicionarVendedor(VendedorDto vendedorDto)
        {
            var vendedorEntity = new VendedorEntity()
            {
                Nome = vendedorDto.Nome,
                Email = vendedorDto.Email,
                Telefone = vendedorDto.Telefone,
                Endereco = vendedorDto.Endereco,
                CriadoEm = vendedorDto.CriadoEm,
                DataContratacao = vendedorDto.DataContratacao,
                DataNascimento = vendedorDto.DataNascimento,
                ComissaoPercentual = vendedorDto.ComissaoPercentual,
                MetaMensal = vendedorDto.MetaMensal
            };

            _repository.Adicionar(vendedorEntity);
        }


        public void AtualizarVendedor(int id, VendedorDto vendedorDto)
        {
            var vendedorEntity = new VendedorEntity()
            {
                Nome = vendedorDto.Nome,
                Email = vendedorDto.Email,
                Telefone = vendedorDto.Telefone,
                Endereco = vendedorDto.Endereco,
                CriadoEm = vendedorDto.CriadoEm,
                DataContratacao = vendedorDto.DataContratacao,
                DataNascimento = vendedorDto.DataNascimento,
                ComissaoPercentual = vendedorDto.ComissaoPercentual,
                MetaMensal = vendedorDto.MetaMensal
            };

            _repository.Atualizar(id, vendedorEntity);
        }

        public void DeletarVendedor(int id)
        {
            _repository.Deletar(id);
        }
    }
}
