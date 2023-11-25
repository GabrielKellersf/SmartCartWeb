using Microsoft.EntityFrameworkCore;
using SmartCart.Context;
using SmartCart.Models;
using SmartCart.Repositories.Interfaces;

namespace SmartCart.Repositories
{
    public class ProdutoRepository : IProdutosRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;   
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutoFavorito => _context.Produtos.Where(p => p.ProdutoFavorito).Include(c => c.Categoria);

        public Produto GetProdutoById(int Produtoid)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == Produtoid);
        }
    } 
}
