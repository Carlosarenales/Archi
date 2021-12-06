using MongoDB.Driver;
using MicroServiceProductos.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroServiceProductos.Services
{
    public class ServicioBD
    {
        private IMongoCollection<Productos> _productos;
        public ServicioBD(IBdConfig config)
        {
            var cliente = new MongoClient(config.Server);
            var database = cliente.GetDatabase(config.Database);
            _productos = database.GetCollection<Productos>(config.Collection);
        }

        public List<Productos> Get()
        {
            return _productos.Find(d => true).ToList();
        }

        public Productos Create(Productos producto)
        {
            _productos.InsertOne(producto);
            return producto;
        }

        public void Update(string id, Productos producto)
        {
            _productos.ReplaceOne(producto => producto.Id == id, producto);
            //return cliente;
        }

        public void Delete(string id)
        {
            _productos.DeleteOne(producto => producto.Id == id);
        }
    }
}
