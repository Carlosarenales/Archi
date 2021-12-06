using MicroServiceEmpleados.Model;
using MicroServiceEmpleados.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ServicioEmpleados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        public ServicioBD _servicioBD;
        public EmpleadosController(ServicioBD servicioBD)
        {
            _servicioBD = servicioBD;
        }
        [HttpGet]
        public ActionResult<List<Empleados>> Get()
        {
            return _servicioBD.Get();
        }

        [HttpPost]
        public ActionResult<Empleados> Create(Empleados empleado)
        {
            _servicioBD.Create(empleado);
            return Ok(empleado);
        }
        [HttpPut]
        public ActionResult Update(Empleados empleado)
        {
            _servicioBD.Update(empleado.Id, empleado);
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
