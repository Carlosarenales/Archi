using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MicroServiceEmpleados.Model
{
    [BsonIgnoreExtraElements]
    public class Empleados
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("apellido")]
        public string Apellido { get; set; }
        [BsonElement("telefono")]
        public string Telefono { get; set; }
        [BsonElement("edad")]
        public string Edad { get; set; }
    }
}
