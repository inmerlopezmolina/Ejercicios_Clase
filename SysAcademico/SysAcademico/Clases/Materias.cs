using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcademico.Clases
{
    /// <summary>
    /// Clase que representa a una materia del sistema academico
    /// </summary>
    public class Materias
    {
        //Declaracion de propiedades
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Docentes Encargado { get; set; }
    }
}
