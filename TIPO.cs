using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen2programacion.clases
{
    public class TIPO
    {
        public int Usuario { get; set; }
        public static string Equipos { get; set; }
        public string Asignaciones { get; set; }
        public string Tecnicos { get; set; }
        public string Reparacion { get; set; }
        public string DetallesReparacion { get; set; }
        public TIPO(int Usuario, String Equipos, string Asignaciones, string Tecnicos, string Reparacion, string DetallesReparacion) //Constructor sirve para inicializar atributos
        {
            Usuario = Usuario;
            Usuario = Usuario;
            Asignaciones = Asignaciones;
            Tecnicos = Tecnicos;
            Reparacion = Reparacion;
            DetallesReparacion = DetallesReparacion;
        }
        public TIPO() { }
        public static void Agregar() { }
        public static void Borrar() { }
        public static void Modificar() { }
        public static void ConsultarporFiltro() { }



 

    }
}