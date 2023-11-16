using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        private IAplicacionComprobante app;
        public ComprobanteController()
        {
            app = new AplicacionComprobante();
        }

        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;

            try
            {
                lst = app.GetClientes();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/empleados")]
        public IActionResult GetEmpleados()
        {
            List<Empleado> lst = null;

            try
            {
                lst = app.GetEmpleados();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpGet("/formas_pago")]
        public IActionResult GetFormasPago()
        {
            List<TipoFormaPago> lst = null;

            try
            {
                lst = app.GetFormasPagos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpPost]
        public IActionResult PostComprobante(Comprobante oC)
        {
            try
            {

                if (oC == null)
                {
                    return BadRequest("Comprobante Inválido,FALTAN CAMPOS...");
                }
                return Ok(app.SaveComprobante(oC));
                
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!! Intente luego");
            }
        }
    }
}
