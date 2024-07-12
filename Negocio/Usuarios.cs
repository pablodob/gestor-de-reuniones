using Modelos;

namespace Negocio
{
    public class Usuarios
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        static Usuarios()
        {
            usuarios.Add(new Usuario("Pablo", "pablo.dob", 1));
            usuarios.Add(new Usuario("Juli", "juli.ru", 2));
            usuarios.Add(new Usuario("Valentin", "ladron.com", 3));
        }

        public static List<Usuario> getAll()
        {
            return usuarios;
        }

        public static void Add(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public static bool Delete(Usuario usuario)
        {
            return usuarios.Remove(usuario);
        }

        public static bool Update(Usuario usuario)
        {
            var obj = usuarios.FirstOrDefault(x => x.Id == usuario.Id);
            if (obj != null)
            {
                obj.NombreUsuario = usuario.NombreUsuario;
                obj.Nombre = usuario.Nombre;
            }
            return obj != null;
        }
    }
}
