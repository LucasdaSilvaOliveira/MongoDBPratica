using MongoDB.Driver;
using MongoDBPratica.Model;

namespace MongoDBPratica.Context
{
    public class Conn
    {
        private const string _server = "mongodb://localhost:27017/";
        private const string _db = "MongoDBPratica";
        private const string _collection = "Produto";
        //public List<Produto> ConnectionCreate()
        public List<Produto> GetAllProdutos()
        {
            var client = new MongoClient(_server);
            var db = client.GetDatabase(_db);
            var myColl = db.GetCollection<Produto>(_collection);

            var filter = Builders<Produto>.Filter.Empty;
            var produtos = myColl.Find(filter).ToList();

            return produtos;
        }
    }
}
