using MongoDB.Bson;
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

        public void InsertProduto(Produto produto)
        {
            var prodCollection = Conn.GetCollection();
            prodCollection.InsertOne(produto);
        }

        public void DeleteProduto(ObjectId id)
        {
            var prodCollection = Conn.GetCollection();
            var filter = Builders<Produto>.Filter.Eq(p => p.Id, id);
            prodCollection.DeleteOne(filter);
        }

        public void UpdateProduto(Produto produto)
        {
            var prodCollection = Conn.GetCollection();
            var filter = Builders<Produto>.Filter.Eq(p => p.Id, produto.Id);
            prodCollection.ReplaceOne(filter, produto);
        }

        public Produto GetProdutoById(ObjectId id)
        {
            var prodCollection = Conn.GetCollection();
            var filter = Builders<Produto>.Filter.Eq(p => p.Id, id);
            var produto = prodCollection.Find(filter).FirstOrDefault();
            return produto;
        }
    }
}
