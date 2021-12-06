using Microsoft.AspNetCore.Mvc;
using MicroServiceClientes.Model;
using MicroServiceClientes.Services;
using System.Collections.Generic;

namespace ServicioClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        public ServicioBD _servicioBD;
        public ClientesController(ServicioBD servicioBD)
        {
            _servicioBD = servicioBD;
        }
        [HttpGet]
        public ActionResult<List<Clientes>> Get()
        {
            return _servicioBD.Get();
        }

        [HttpPost]
        public ActionResult<Clientes> Create(Clientes cliente)
        {
            _servicioBD.Create(cliente);
            return Ok(cliente);
        }
        [HttpPut]
        public ActionResult Update(Clientes cliente)
        {
            _servicioBD.Update(cliente.Id, cliente);
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
