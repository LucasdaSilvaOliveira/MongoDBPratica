using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MongoDBPratica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public ProdutoController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok("Testando");
        }
    }
}
