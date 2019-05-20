using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton.AccesoDatos
{
    /// <summary>
    /// Clases que representa un estudiante
    /// </summary>
    public class Alumnos
    {
        //Declaracion de propiedades
        public int NIE { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Grado { get; set; }
    }
}
