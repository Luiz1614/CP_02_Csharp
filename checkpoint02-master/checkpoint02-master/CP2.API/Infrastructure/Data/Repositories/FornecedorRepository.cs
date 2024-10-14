using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Adicionar(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
        }

        public void Atualizar(int id, FornecedorEntity fornecedor)
        {
            var existingEntity = _context.Set<FornecedorEntity>().Find(id);

            if (existingEntity != null)
            {
                existingEntity.Nome = fornecedor.Nome;
                existingEntity.CNPJ = fornecedor.CNPJ;
                existingEntity.Telefone = fornecedor.Telefone;
                existingEntity.Email = fornecedor.Email;
                existingEntity.Endereco = fornecedor.Endereco;

                _context.Entry(existingEntity).State = EntityState.Modified;

                _context.SaveChanges();
            }
        }
        
        public void Deletar(int id)
        {
            var entity = _context.Fornecedor.Find(id);
            if (entity != null)
            {
                _context.Fornecedor.Remove(entity);
                _context.SaveChanges();
            }
        }

        public FornecedorEntity ObterPorId(int id)
        {
            return _context.Set<FornecedorEntity>().Find(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodos()
        {
            return _context.Set<FornecedorEntity>().ToList();
        }
    }
}
