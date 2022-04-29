using Microsoft.AspNetCore.Mvc;

namespace BackEndClase.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController: ControllerBase
    {
        //Propiedad publica
        public string PropiedadBiblioteca { get; set; }

        
        public BibliotecaController()
        {
            // Constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            //Función
            return "No seas pendejo";
        }

        [HttpPost]
        public string AgregarLibro()
        {
            //Función
            return "No seas pendejo";
        }

        [HttpPut]
        public string ActualizarLibro()
        {
            //Función
            return "No seas pendejo";
        }
    }
}
