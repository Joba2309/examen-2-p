using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Resultados
{
    public class Class1
    {
        // Ejemplo de uso en la capa de presentación
        class Program
        {
            static void Main()
            {
                var dataAccess = ;

                // Agregar un nuevo equipo
                var nuevoEquipo = new { Nombre = "Nuevo Equipo", Descripcion = "Descripción", Estado = "Activo" };
                dataAccess.AgregarEquipo(nuevoEquipo);

                // Borrar un usuario por ID
                dataAccess.BorrarUsuario(5);

                // Consultar equipos por estado
                var equiposActivos = dataAccess.ConsultarEquiposPorEstado("Activo");

                // Modificar la descripción de un equipo por su ID
                dataAccess.ModificarDescripcionEquipo(3, "Nueva descripción");
            }
        }
















    }
}
