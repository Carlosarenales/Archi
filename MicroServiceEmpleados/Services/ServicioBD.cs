using MongoDB.Driver;
using MicroServiceEmpleados.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroServiceEmpleados.Services
{
    public class ServicioBD
    {
        private IMongoCollection<Empleados> _empleados;
        public ServicioBD(IBdConfig config)
        {
            var cliente = new MongoClient(config.Server);
            var database = cliente.GetDatabase(config.Database);
            _empleados = database.GetCollection<Empleados>(config.Collection);
        }

        public List<Empleados> Get()
        {
            return _empleados.Find(d => true).ToList();
        }

        public Empleados Create(Empleados empleados)
        {
            _empleados.InsertOne(empleados);
            return empleados;
        }

        public void Update(string id, Empleados empleados)
        {
            _empleados.ReplaceOne(empleados => empleados.Id == id, empleados);            
        }

        public void Delete(string id)
        {
            _empleados.DeleteOne(empleados => empleados.Id == id);
        }
    }
}
