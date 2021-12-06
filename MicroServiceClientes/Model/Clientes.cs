using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MicroServiceClientes.Model
{
    [BsonIgnoreExtraElements]
    public class Clientes
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("identificacion")]
        public string Identificacion { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellido")]
        public string Apellido { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("direccion")]
        public string Direccion { get; set; }

        [BsonElement("ciudad")]
        public string Ciudad { get; set; }

        [BsonElement("fechaRegistro")]
        public DateTime FechaRegistro { get; set; }
    }
}
