using Microsoft.AspNetCore.Mvc;
using SmartCart.Repositories.Interfaces;


// Busca os produtos no DB

namespace SmartCart.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutoController(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        public IActionResult List()
        {
            var Produtos = _produtosRepository.Produtos;
            return View(Produtos);
        }
    }
}
