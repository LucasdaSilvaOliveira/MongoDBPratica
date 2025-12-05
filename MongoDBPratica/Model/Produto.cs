using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBPratica.Model
{
    public class Produto
    {
        //[BsonElement("_id")]
        //[BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public string Id { get; set; }
        //public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
