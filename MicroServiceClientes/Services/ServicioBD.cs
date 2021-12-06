using MongoDB.Driver;
using MicroServiceClientes.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroServiceClientes.Services
{
    public class ServicioBD
    {
        private IMongoCollection<Clientes> _clientes;
        public ServicioBD(IBdConfig config)
        {
            var cliente = new MongoClient(config.Server);
            var database = cliente.GetDatabase(config.Database);
            _clientes = database.GetCollection<Clientes>(config.Collection);
        }

        public List<Clientes> Get()
        {
            return _clientes.Find(d => true).ToList();
        }

        public Clientes Create(Clientes cliente)
        {
            _clientes.InsertOne(cliente);
            return cliente;
        }

        public void Update(string id, Clientes cliente)
        {
            _clientes.ReplaceOne(cliente => cliente.Id == id, cliente);
        }

        public void Delete(string id)
        {
            _clientes.DeleteOne(cliente => cliente.Id == id);
        }
    }
}
