using BackEndClase.Datos.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BackEndClase.Datos.Servicio
{
    public class RepositorioBiblioteca: DbContext
    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) : base(options)
        {
            
        }
        public DbSet<Libro> Libros { get; set; }
        // Crear otras 3 propiedades restantes (Autor, Estudiante, Prestamo)
    }
}
