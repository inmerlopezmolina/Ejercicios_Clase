using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysAcademico.Clases;

namespace SysAcademico.Modelo
{
    public class SysAcademico
    {
        //Declaracion de variables
        private List<Docentes> listaDocentes;
        private List<Estudiante> listaAlumnos;

        //Declaracion de propiedades
        protected List<Materias> listaMaterias { get; set; }

        /// <summary>
        /// Inicializamos los elementos de la clase
        /// </summary>
        public SysAcademico() {
            //inicializamos las variables
            this.listaDocentes = new List<Docentes>();
            this.listaAlumnos = new List<Estudiante>();
            this.listaMaterias = new List<Materias>();
        }

        /// <summary>
        /// Permite el registro de un docente a la lista de docentes
        /// </summary>
        /// <param name="DocenteaRegistrar">docente a registrar</param>
        /// <returns>True->Docente registrado con exito
        /// False->Error al registrar el docente
        /// </returns>
        protected bool RegistrarDocente(Docentes DocenteaRegistrar) {
            try
            {
                this.listaDocentes.Add(DocenteaRegistrar);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        

        /// <summary>
        /// Permite el registro de un Materia a la lista de Materias
        /// </summary>
        /// <param name="MateriaaRegistrar">Materia a registrar</param>
        /// <returns>True->Materia registrada con exito
        /// False->Error al registrar la materia
        /// </returns>
        protected bool RegistrarMateria(Materias MateriaaRegistrar)
        {
            try
            {
                this.listaMaterias.Add(MateriaaRegistrar);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Permite el registro de un estudiante a la lista de Estudiantes
        /// </summary>
        /// <param name="EstudianteaRegistrar">Estudiante a registrar</param>
        /// <returns>True->Materia registrada con exito
        /// False->Error al registrar la materia
        /// </returns>
        protected bool RegistrarEstudiante(Estudiante EstudianteaRegistrar)
        {
            try
            {
                this.listaAlumnos.Add(EstudianteaRegistrar);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Funcion que permite obtener la lista de estudiantes
        /// </summary>
        /// <returns></returns>
        protected List<Estudiante> GetEstudiantes() {
            return this.listaAlumnos;
        }

        /// <summary>
        /// Funcion que permite obtener la lista de Docentes
        /// </summary>
        /// <returns></returns>
        protected List<Docentes> GetDocentes() {
            return this.listaDocentes;
        }

        /// <summary>
        /// Funcion que permite obtener la lista de Materia
        /// </summary>
        /// <returns></returns>
        protected List<Materias> GetMateria()
        {
            return this.listaMaterias;
        }
    }
}
