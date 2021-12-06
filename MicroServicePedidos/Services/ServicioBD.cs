using MongoDB.Driver;
using MicroServicePedidos.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroServicePedidos.Services
{
    public class ServicioBD
    {
        private IMongoCollection<Pedidos> _pedidos;
        public ServicioBD(IBdConfig config)
        {
            //var credential = MongoCredential.CreateMongoCRCredential(config.Database, "root", "freepass");

            //var settings = new MongoClientSettings
            //{
            //    Credentials = new[] { credential }
            //};


            var cliente = new MongoClient(config.Server);
            var database = cliente.GetDatabase(config.Database);
            _pedidos = database.GetCollection<Pedidos>(config.Collection);
        }

        public List<Pedidos> Get()
        {
            return _pedidos.Find(d => true).ToList();
        }

        public Pedidos Create(Pedidos pedido)
        {
            _pedidos.InsertOne(pedido);
            return pedido;
        }

        public void Update(string id, Pedidos pedido)
        {
            _pedidos.ReplaceOne(pedido => pedido.Id == id, pedido);            
        }

        public void Delete(string id)
        {
            _pedidos.DeleteOne(pedido => pedido.Id == id);
        }
    }
}
