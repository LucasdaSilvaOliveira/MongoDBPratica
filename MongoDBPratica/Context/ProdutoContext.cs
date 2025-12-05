using MongoDB.Driver;
using MongoDBPratica.Model;

namespace MongoDBPratica.Context
{
    public class ProdutoContext
    {
        public List<Produto> GetAllProdutos()
        {
            var prodCollection = Conn.GetCollection();
            var filter = Builders<Produto>.Filter.Empty;
            var produtos = prodCollection.Find(filter).ToList();
            return produtos;
        }
    }
}
