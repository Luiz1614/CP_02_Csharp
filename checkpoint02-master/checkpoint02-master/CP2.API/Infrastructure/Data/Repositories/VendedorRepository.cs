using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Adicionar(VendedorEntity vendedor)
        {
            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();
        }

        public void Atualizar(int id, VendedorEntity vendedor)
        {
            var existingEntity = _context.Set<VendedorEntity>().Find(id);

            if (existingEntity != null)
            {
                existingEntity.Nome = vendedor.Nome;
                existingEntity.Telefone = vendedor.Telefone;
                existingEntity.Email = vendedor.Email;
                existingEntity.Endereco = vendedor.Endereco;
                existingEntity.MetaMensal = vendedor.MetaMensal;
                existingEntity.ComissaoPercentual = vendedor.ComissaoPercentual;
                existingEntity.CriadoEm = vendedor.CriadoEm;
                existingEntity.DataContratacao = vendedor.DataContratacao;
                existingEntity.DataNascimento = vendedor.DataNascimento;

                _context.Entry(existingEntity).State = EntityState.Modified;

                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var entity = _context.Vendedor.Find(id);
            if (entity != null)
            {
                _context.Vendedor.Remove(entity);
                _context.SaveChanges();
            }
        }

        public VendedorEntity ObterPorId(int id)
        {
            return _context.Set<VendedorEntity>().Find(id);
        }

        public IEnumerable<VendedorEntity> ObterTodos()
        {
            return _context.Set<VendedorEntity>().ToList();
        }
    }
}
