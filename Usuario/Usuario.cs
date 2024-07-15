using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Usuario
    {
        public Usuario()
        {
            //Nombre = "pablo";
            //NombreUsuario = "pablodob";
        }

        public Usuario(string nombre,
                       string nombreUsuario,
                       int id
            )
        {
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Id = id;
        }
        /*
        public Usuario(string nombre,
               string nombreUsuario)
        {
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
        }*/


        public string? Nombre { get; set; }
        public string? NombreUsuario { get; set; }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public override bool Equals(object? obj)
        {
            /*
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Usuario u = (Usuario)obj;
            return Nombre.Equals(u.Nombre) && NombreUsuario.Equals(u.NombreUsuario) && Id == u.Id;
            */
            
            return obj is Usuario usuario &&
                   Nombre == usuario.Nombre &&
                   NombreUsuario == usuario.NombreUsuario &&
                   Id == usuario.Id;
        }
    }    
}
