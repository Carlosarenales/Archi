using Microsoft.AspNetCore.Mvc;
using MicroServiceProductos.Model;
using MicroServiceProductos.Services;
using System.Collections.Generic;

namespace MicroServiceProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        public ServicioBD _servicioBD;
        public ProductosController(ServicioBD servicioBD)
        {
            _servicioBD = servicioBD;
        }
        [HttpGet]
        public ActionResult<List<Productos>> Get()
        {
            return _servicioBD.Get();
        }

        [HttpPost]
        public ActionResult<Productos> Create(Productos producto)
        {
            _servicioBD.Create(producto);
            return Ok(producto);
        }
        [HttpPut]
        public ActionResult Update(Productos producto)
        {
            _servicioBD.Update(producto.Id, producto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _servicioBD.Delete(id);
            return Ok();
        }
    }
}
