using System.ComponentModel.DataAnnotations;

namespace BackEndClase.Datos.Modelo
{
    public class Autor
    {
        [Key]
        public int NumeroDeAutor { get; set; }
        public string CategoriaDelAutor { get; set; }

        public string LibrosDelAutor { get; set; }
        public string NombreDelAutor { get; set; }
        public int NumeroDeLibros { get; set; }
    }
}
