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
        //Completar...
    }
}
