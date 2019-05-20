using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton.AccesoDatos
{
    public class clsBaseDatos
    {
        //Declaracion de variables Estaticas
        private List<Alumnos> db;

        //Propiedad de Acceso
        /// <summary>
        /// Devuelve la base de datos de estudiantes
        /// </summary>
        public List<Alumnos> GetBaseDatos {
            get {
                return this.db;
            }
        }
        public clsBaseDatos() {
            this.db = new List<Alumnos>();
        }

        /// <summary>
        /// Funcion para poder agregar un alumno a la base de datos
        /// </summary>
        /// <param name="nuevoAlumno">Alumno a ingresar a la base de datos</param>
        /// <returns></returns>
        public bool AgregarAlumno(Alumnos nuevoAlumno) {
            try
            {
                this.db.Add(nuevoAlumno);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        /// <summary>
        /// Funcion que permite modificar un alumno de la base de datos
        /// </summary>
        /// <param name="AlumnoModificar">Alumno a modificar</param>
        /// <returns></returns>
        public bool ModificarAlumno(Alumnos AlumnoModificar) {
            try
            {
                //Buscamos el indice del alumno a modificar
                int IndiceAlumno = this.db.FindIndex(alumn => alumn.NIE == AlumnoModificar.NIE);
                this.db[IndiceAlumno] = AlumnoModificar;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Funcion que permite modificar un alumno de la base de datos
        /// </summary>
        /// <param name="AlumnoEliminar">Alumno a eliminar de la base de datos</param>
        /// <returns></returns>
        public bool EliminarAlumno(Alumnos AlumnoEliminar)
        {
            try
            {
                //Eliminamos al alumno
                return this.db.Remove(AlumnoEliminar);
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
