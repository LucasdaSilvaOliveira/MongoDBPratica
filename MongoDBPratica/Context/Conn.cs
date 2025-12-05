using MongoDB.Driver;
using MongoDBPratica.Model;

namespace MongoDBPratica.Context
{
    public class Conn
    {
        private const string _server = "mongodb://localhost:27017/";
        private const string _db = "MongoDBPratica";
        private const string _collection = "Produto";

        private static IMongoDatabase CreateConnect()
        {
            var client = new MongoClient(_server);
            var db = client.GetDatabase(_db);

            return db;
        }

        public static IMongoCollection<Produto> GetCollection()
        {
            var db = CreateConnect();
            var myColl = db.GetCollection<Produto>(_collection);
            return myColl;
        }
    }
}