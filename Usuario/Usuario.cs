namespace Modelos
{
    public class Usuario
    {
        public Usuario()
        {
            Nombre = "pablo";
            NombreUsuario = "pablodob";
            Id = 1;
        }

        public Usuario(string nombre,
                       string nombreUsuario,
                       int id)
        {
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Id = id;
        }

        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
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
