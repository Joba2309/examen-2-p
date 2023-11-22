using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Consultar
{
    public class Class1
    {
        // Clase para la tabla Equipos
        public class Equipo
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Estado { get; set; }
        }

        // Clase para la tabla Usuarios
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
            public string Rol { get; set; }
        }

        // Clase para la tabla Técnicos
        public class Tecnico
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Especialidad { get; set; }
            public int Experiencia { get; set; }
        }






    }
}
