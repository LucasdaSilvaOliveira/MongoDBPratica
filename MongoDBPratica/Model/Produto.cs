using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBPratica.Model
{
    public class Produto
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
