using System.ComponentModel.DataAnnotations;

namespace BackEndClase.Datos.Modelo
{
    public class Estudiante
    {
        [Key]
        public int IdDelEstudiante { get; set; }
        public string Nombre { get; set; }

        public string Carrera { get; set; }
        public string Edad { get; set; }
        public int NumeroDeIdentificacion { get; set; }
    }
}
