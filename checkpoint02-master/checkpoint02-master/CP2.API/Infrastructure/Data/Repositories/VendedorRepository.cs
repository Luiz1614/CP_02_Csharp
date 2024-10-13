using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

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
                _context.Entry(existingEntity).CurrentValues.SetValues(vendedor);
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

        public IEnumerable<FornecedorEntity> ObterTodos()
        {
            return _context.Set<FornecedorEntity>().ToList();
        }
    }
}
