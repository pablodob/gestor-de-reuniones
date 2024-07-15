using Modelos;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public sealed class Conexion : DbContext
    {

        private Conexion(DbContextOptions<Conexion> options) : base(options) { }

        public DbSet<Usuario> usuario { get; set; }

        private static Conexion? instancia;

        public static Conexion CreateContext()
        {
            if (instancia == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=reuniones2;TrustServerCertificate=True;Integrated Security=True;");
                instancia = new Conexion(optionsBuilder.Options);
            }
            return instancia;

        }

    }
}
