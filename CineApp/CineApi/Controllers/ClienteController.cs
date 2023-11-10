using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IAplicacion app;

        public ClienteController()
        {
            app = new Aplicacion();
        }

        // GET: api/<ClienteController>
        [HttpGet("/barrios")]
        public IActionResult GetBarrios()
        {
            List<Barrio> lst = null;

            try
            {
                lst = app.GetBarrios();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult PostCliente(Cliente oCliente)
        {
            try
            {

                if (oCliente == null)
                {
                    return BadRequest("Cliente Invalido,FALTAN CAMPOS...");
                }
                if (app.SaveCliente(oCliente))
                {
                    return Ok(oCliente);
                }
                else
                {
                    return NotFound("No se pudo guardar el cliente!!!");
                }


            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!! Intente luego");
            }
        }

        //// GET api/<ClienteController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ClienteController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ClienteController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ClienteController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
