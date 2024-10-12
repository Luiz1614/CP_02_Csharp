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

        public void Atualizar(VendedorEntity vendedor)
        {
            _context.Vendedor.Update(vendedor);
            _context.SaveChanges();
        }

        public void Deletar(VendedorEntity vendedor)
        {
            _context.Vendedor.Remove(vendedor);
            _context.SaveChanges();
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
