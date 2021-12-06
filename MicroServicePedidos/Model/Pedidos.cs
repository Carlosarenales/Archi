using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MicroServicePedidos.Model
{
    [BsonIgnoreExtraElements]
    public class Pedidos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("idCliente")]
        public string idCliente { get; set; }

        [BsonElement("productos")]
        public string[] productos { get; set; }

        [BsonElement("idVendedor")]
        public string idVendedor { get; set; }

        [BsonElement("estado")]
        public string estado { get; set; }
    }
}
