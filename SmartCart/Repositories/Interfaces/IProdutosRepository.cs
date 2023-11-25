using SmartCart.Models;
using System.Numerics;

namespace SmartCart.Repositories.Interfaces
{
    public interface IProdutosRepository
    {
        IEnumerable<Produto> Produtos { get; }

        IEnumerable<Produto> ProdutoFavorito { get; }

        Produto GetProdutoById (int Produtoid);
    }

}
