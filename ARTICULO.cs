using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen2programacion.clases
{
    public class ARTICULO
    {
        public int Usuario { get; set; }
        public int Equipos { get; set; }
        public string Asignaciones { get; set; }
        public string Tecnicos { get; set; }
        public string Reparacion { get; set; }
        public string DetallesReparacion { get; set; }
        public ARTICULO(int Usuario, String Equipos, string Asignaciones, string Tecnicos, string Reparacion, string DetallesReparacion)
        {
            this.Usuario = Usuario;
            this.Usuario = Usuario;
            this.Asignaciones = Asignaciones;
            this.Tecnicos = Tecnicos;
            this.Reparacion = Reparacion;
            this.DetallesReparacion = DetallesReparacion;


        }


    }
}