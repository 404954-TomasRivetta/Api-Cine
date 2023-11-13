using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private IAplicacionPelicula app;
        public PeliculaController()
        {
            app = new AplicacionPelicula();
        }

          [HttpGet("/actores")]
        public IActionResult GetActoresPel()
        {
            List<Actor> lst = null;

            try
            {
                lst = app.GetActoresPel();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpGet("/dialectos")]
        public IActionResult GetDialectos()
        {
            List<Dialecto> lst = null;

            try
            {
                lst = app.GetDialectos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpGet("/directores")]
        public IActionResult GetDirectores()
        {
            List<Director> lst = null;

            try
            {
                lst = app.GetDirectores();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        
        [HttpGet("/tipos_pelicula")]
        public IActionResult GetTiposPeliculas()
        {
            List<TipoPelicula> lst = null;

            try
            {
                lst = app.GetTiposPeliculas();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }


        [HttpGet("/tipos_publico")]
        public IActionResult GetTiposPublicos()
        {
            List<TipoPublico> lst = null;

            try
            {
                lst = app.GetTiposPublicos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpPost]
        public IActionResult SavePelicula(Pelicula pel)
        {
            try
            {

                if (pel == null)
                {
                    return BadRequest("Pelicula Inválida, FALTAN CAMPOS...");
                }
                if (app.SavePelicula(pel))
                {
                    return Ok(pel);
                }
                else
                {
                    return NotFound("No se pudo guardar la pelicula!!!");
                }


            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!! Intente luego");
            }
        }
    }
}
