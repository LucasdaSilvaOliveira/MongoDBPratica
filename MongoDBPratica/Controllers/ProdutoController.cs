using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBPratica.Context;
using MongoDBPratica.DTOs;

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

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(string id) 
        {
            var objectId = new MongoDB.Bson.ObjectId(id);
            var produto = _produtoContext.GetProdutoById(objectId);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddProdutoDTO produtoDTO)
        {
            var produto = new Model.Produto
            {
                Nome = produtoDTO.Nome,
                Preco = produtoDTO.Preco
            };

            _produtoContext.InsertProduto(produto);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var objectId = new MongoDB.Bson.ObjectId(id);
            _produtoContext.DeleteProduto(objectId);
            return Ok("Produto removido com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProdutoDTO produtoDTO)
        {
            var objectId = new MongoDB.Bson.ObjectId(produtoDTO.Id);
            var produto = new Model.Produto
            {
                Id = objectId,
                Nome = produtoDTO.Nome,
                Preco = produtoDTO.Preco
            };
            _produtoContext.UpdateProduto(produto);
            return Ok(produto);
        }
    }
}
