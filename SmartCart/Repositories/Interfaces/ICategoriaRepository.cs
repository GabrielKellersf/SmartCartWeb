using Microsoft.EntityFrameworkCore;
using SmartCart.Models;

namespace SmartCart.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categotias { get; }
    }
}
