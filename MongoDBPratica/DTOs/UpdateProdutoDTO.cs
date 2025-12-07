using MongoDB.Bson;

namespace MongoDBPratica.DTOs
{
    public class UpdateProdutoDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
