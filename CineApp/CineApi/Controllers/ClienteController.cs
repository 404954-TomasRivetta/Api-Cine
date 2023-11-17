using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IAplicacionCliente app;
        public ClienteController()
        {
            app = new AplicacionCliente();
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
        [HttpPost("/cliente")]
        public IActionResult PostCliente(Cliente oCliente)
        {
            try
            {

                if (oCliente == null)
                {
                    return BadRequest("Cliente Invalido,FALTAN CAMPOS...");
                }
                return Ok(app.SaveCliente(oCliente));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!! Intente luego");
            }
        }
        [HttpPut("clientes_modificar/{id}")]        
        public async Task<IActionResult> Put(int id, Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Cliente Invalido, FALTAN CAMPOS...");
                }

                bool result = app.ModifyCliente(id,cliente);
                if (result)
                {
                    return Ok("Cliente modificado correctamente");
                }
                else
                {
                    return BadRequest("No se pudo modificar el cliente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }


        [HttpGet("/clientesFiltrados")]
        public IActionResult GetClientesFiltrados(DateTime FechaDesde, DateTime FechaHasta, int idBarrio, string apellido)
        {
            List<Cliente> lst = null;
            try
            {

                lst = app.GetClientesFiltrados2(FechaDesde, FechaHasta, idBarrio, apellido);
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/DeleteCliente")]
        public IActionResult DeleteCliente(int idCliente)
        {
            try
            {
                if (idCliente == 0)
                {
                    return BadRequest("Numero de cliente incorrecto");
                }
                bool eliminado = app.DeleteCliente(idCliente);
                return Ok(eliminado);

            }
            catch (Exception E)
            {
                return StatusCode(500, E.Message);
            }
        }

        [HttpGet("/clientes/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                Cliente cliente = await app.GetClientesIdAsync(id);
                if (cliente != null)
                    return Ok(cliente);
                else
                    return NotFound("Cliente Nro: " + id + " NO encontrado!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }            
        }
        
    }
    



    

        //// DELETE api/<ClienteController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
 }

