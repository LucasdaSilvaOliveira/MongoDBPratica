using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBPratica.Context;

namespace MongoDBPratica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext _produtoContext;
        public ProdutoController(ProdutoContext produtoContext)
        {
            _produtoContext = produtoContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var produtos = _produtoContext.GetAllProdutos();
            return Ok(produtos);
        }
    }
}
