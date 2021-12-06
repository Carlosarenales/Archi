using Microsoft.AspNetCore.Mvc;
using MicroServicePedidos.Model;
using MicroServicePedidos.Services;
using System.Collections.Generic;

namespace ServicioPedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        public ServicioBD _servicioBD;
        public PedidosController(ServicioBD servicioBD)
        {
            _servicioBD = servicioBD;
        }
        [HttpGet]
        public ActionResult<List<Pedidos>> Get()
        {
            return _servicioBD.Get();
        }

        [HttpPost]
        public ActionResult<Pedidos> Create(Pedidos pedido)
        {
            _servicioBD.Create(pedido);
            return Ok(pedido);
        }
        [HttpPut]
        public ActionResult Update(Pedidos pedido)
        {
            _servicioBD.Update(pedido.Id, pedido);
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
