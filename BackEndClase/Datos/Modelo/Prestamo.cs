using System.ComponentModel.DataAnnotations;

namespace BackEndClase.Datos.Modelo
{
    public class Prestamo
    {
        [Key]
        public int Estudiante { get; set; }
        public string Libro { get; set; }

        public string Autor { get; set; }
        public string Categoria { get; set; }
        public int NumeroDeDias { get; set; }
    }
}
