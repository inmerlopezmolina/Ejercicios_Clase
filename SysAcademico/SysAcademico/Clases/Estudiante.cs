using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcademico.Clases
{
    /// <summary>
    /// Clase que representa a un estudiante del sistema academico
    /// </summary>
    public class Estudiante : Persona
    {
        //Declaracion de propiedades
        public Grado GradoCursado { get; set; }
        public int NIE { get; set; }

    }
}
