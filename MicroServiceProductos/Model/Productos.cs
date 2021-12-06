using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MicroServiceProductos.Model
{
    [BsonIgnoreExtraElements]
    public class Productos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("referencia")]
        public string Referencia { get; set; }

        [BsonElement("cantidad")]
        public int Cantidad { get; set; }

        [BsonElement("precio")]
        public int Precio { get; set; }
    }
}
