using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Reunion
    {
        public Reunion(DateOnly fecha, string? titulo, Usuario coordinador, List<Usuario> participantes, string estado, int id)
        {
            Fecha = fecha;
            Titulo = titulo;
            Coordinador = coordinador;
            Participantes = participantes;
            Estado = estado;
            Id = id;
        }

        public DateOnly Fecha { get; set; }
        public string? Titulo { get; set; }
        public Usuario Coordinador { get; set; }
        public List<Usuario> Participantes { get; set; }
        public string Estado {  get; set; }
        public int Id { get; set; }
    }
}
