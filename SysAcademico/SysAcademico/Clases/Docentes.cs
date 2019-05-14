using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcademico.Clases
{
    /// <summary>
    /// Representa a un docente dentro del sistema academico
    /// </summary>
    public class Docentes : Persona
    {
        //Definicion de propiedades
        public Grado GradoaCargo { get; set; }
        public int NumEscalafon { get; set; }
    }
}
