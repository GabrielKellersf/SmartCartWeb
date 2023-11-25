using SmartCart.Context;
using SmartCart.Models;
using SmartCart.Repositories.Interfaces;

namespace SmartCart.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categotias => _context.Categorias;
    }
}
