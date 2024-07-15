using Modelos;
using Datos;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Negocio
{
    public class Usuarios
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        /*static Usuarios()
        {
            usuarios.Add(new Usuario("Pablo", "pablo.dob", 1));
            usuarios.Add(new Usuario("Juli", "juli.ru", 2));
            usuarios.Add(new Usuario("Valentin", "ladron.com", 3));
        }*/

        public static List<Usuario> getAll()
        {
            return Conexion.CreateContext().usuario.ToList();
        }

        public static void Add(Usuario usuario)
        {
            Conexion.CreateContext().Add(usuario);
            Conexion.CreateContext().SaveChanges();
        }

        public static void Delete(Usuario usuario)
        {
            Conexion.CreateContext().usuario.Remove(usuario);
            Conexion.CreateContext().SaveChanges();
        }

        public static void Update(Usuario usuario)
        {
            Conexion.CreateContext().usuario.Attach(usuario);
            Conexion.CreateContext().Entry(usuario).State = EntityState.Modified;
            Conexion.CreateContext().SaveChanges();
            /*
            var obj = usuarios.FirstOrDefault(x => x.Id == usuario.Id);
            if (obj != null)
            {
                obj.NombreUsuario = usuario.NombreUsuario;
                obj.Nombre = usuario.Nombre;
            }
            return obj != null;*/
        }

        public static Usuario? RecuperarUno(int id)
        {
            return Conexion.CreateContext().usuario.FirstOrDefault(p => p.Id== id);
        }
    }
}
