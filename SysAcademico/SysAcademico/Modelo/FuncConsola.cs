using SysAcademico.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcademico.Modelo
{
    public class FuncConsola : SysAcademico
    {
        //declaracion de variables
        int Opcionseleccionada = 0;

        /// <summary>
        /// Mostramos el menu de la aplicación de consola
        /// </summary>
        private void MostrarMenu() {
            //Creamos el menu principal
            Console.WriteLine("     .::Sistema Academico::.   ");
            Console.WriteLine(" 1) Registrar Docente");
            Console.WriteLine(" 2) Registrar Alumno");
            Console.WriteLine(" 3) Registrar Materia");
            Console.WriteLine(" 4) Asignar Materia Docente");
            Console.WriteLine(" 5) Inscribir Materia");
            Console.WriteLine("=====================================");
            Console.WriteLine(" 6) Mostrar Docentes");
            Console.WriteLine(" 7) Mostrar Alumnos");
            Console.WriteLine(" 8) Mostrar Materias");
            Console.WriteLine(" 9) Salir");
            Console.Write("Ingrese su opción: ");
            this.Opcionseleccionada = int.Parse(Console.ReadLine());
        }

        public void CicloApp() {
            //Creamos el ciclo de la aplicación
            do
            {
                //Limpiamos la consola
                Console.Clear();
                //Mostramos el menu de opciones
                this.MostrarMenu();

                //Evaluamos la opcion que selecciono el usuario
                switch (this.Opcionseleccionada)
                {
                    case 1:
                        //registrar Docente
                        RegistrarDocente();
                        break;
                    case 2:
                        //registrar Alumno
                        RegistrarEstudiante();
                        break;
                    case 3:
                        //registrar materia
                        RegistrarMateria();
                        break;
                    case 4:
                        //Asignar materia a docente
                        AsignarMateriaaDocente();
                        break;
                    case 5:
                        //Inscribir Materia
                        InscribirMateria();
                        break;
                    case 6:
                        //Mostrar Docentes
                        MostrarDocentes();
                        break;
                    case 7:
                        //Mostrar Alumnos
                        MostrarAlumnos();
                        break;
                    case 8:
                        //Mostrar Materia
                        MostrarMateria();
                        break;
                    case 9:
                        //Salir
                        Console.WriteLine("Gracias por utilizar la aplicación... =]");
                        Console.ReadKey();
                        break;
                    default:
                        //Opcion invalida
                        Console.WriteLine("Ingrese una opcion valida...");
                        Console.ReadKey();
                        break;
                }
            } while (this.Opcionseleccionada != 9);
        }

        private void MostrarMateria()
        {
            //Limpiamos la consola
            Console.Clear();

            Console.WriteLine("======LISTA DE MATERIAS========");

            //Recorremos la lista de docentes
            int cont = 1;
            foreach (var Materia in base.listaMaterias)
            {
                //Imprimimos los docentes
                Console.WriteLine("     " + cont + ") " +
                    Materia.Nombre + 
                    " Encargado: " + Materia.Encargado.Nombre +
                    " " + Materia.Encargado.Apellido);
                cont++;
            }

            //hacemos la espera
            Console.ReadKey();
        }

        private void MostrarAlumnos()
        {
            //Limpiamos la consola
            Console.Clear();

            Console.WriteLine("======LISTA DE ESTUDIANTES========");

            //Recorremos la lista de docentes
            int cont = 1;
            foreach (var Estudiante in base.GetEstudiantes())
            {
                //Imprimimos los docentes
                Console.WriteLine("     " + cont + ") " +
                    Estudiante.Nombre + " " +
                    Estudiante.Apellido +
                    " Grado: " + Estudiante.GradoCursado.Nombre +
                    " Sección: " + Estudiante.GradoCursado.Seccion);
                cont++;
            }

            //hacemos la espera
            Console.ReadKey();
        }

        private void MostrarDocentes(bool AsignarMateria=false)
        {
            //Limpiamos la consola
            Console.Clear();

            Console.WriteLine("======LISTA DE DOCENTES========");

            //Recorremos la lista de docentes
            int cont = 1;
            foreach (var docente in base.GetDocentes())
            {
                //Imprimimos los docentes
                Console.WriteLine("     "+ cont + ") " + 
                    docente.Nombre + " " + 
                    docente.Apellido + 
                    " Grado: " + docente.GradoaCargo.Nombre +
                    " Sección: " + docente.GradoaCargo.Seccion);
                cont++;
            }

            //Validamos que si es asignacion de materia
            if (AsignarMateria)
            {
                Console.WriteLine("[Presione una tecla para seleccionar un docente...]");
            }
            
            //hacemos la espera
            Console.ReadKey();
        }

        private void InscribirMateria()
        {


            Console.WriteLine("Inscribimos Materia");
            //hacemos la espera
            Console.ReadKey();
        }

        private void AsignarMateriaaDocente()
        {

            Console.Clear();
            Console.WriteLine(".::Asignamos Materia::.");

            //Mostramos la lista de Materia
            this.MostrarMateria();
            Console.Write("ID de la Materia Asignar: ");
            int IdMateria = int.Parse(Console.ReadLine());

            //Obtenemos la Materia 
            var MateriaSel = base.GetMateria()[IdMateria - 1];

            //Mostramos la lista docente
            this.MostrarDocentes(true);
            Console.WriteLine(" ID del Docente a Designar: ");
            int IdDocente = int.Parse(Console.ReadLine());

            var DocenteSel = base.GetDocentes()[IdDocente - 1];

            MateriaSel.Encargado = DocenteSel;

            //hacemos la espera
            Console.ReadKey();
        }

        private void RegistrarMateria()
        {
            Console.Clear();
            Console.WriteLine(".::Registrar Materia::.");

            //Creamos el nuevo docente
            Materias nuevaMateria = new Materias();
            Console.Write("Nombre de la Materia: ");
            nuevaMateria.Nombre = Console.ReadLine();
            Console.Write("Descripción de la Materia: ");
            nuevaMateria.Descripcion = Console.ReadLine();

            //Mostramos la lista de docentes
            this.MostrarDocentes(true);
            Console.WriteLine("Id del Docente a Designar:");
            int IdDocente = int.Parse(Console.ReadLine());

            //Obtenemos el docente encargado
            var DocenteSel = base.GetDocentes()[IdDocente - 1];
            nuevaMateria.Encargado = DocenteSel;

            //Guardamos la nueva materia
            base.RegistrarMateria(nuevaMateria);

            //Mensaje de Guardado
            Console.WriteLine("Materia guardada con exito...");

            //hacemos la espera
            Console.ReadKey();
        }

        private void RegistrarEstudiante()
        {
            Console.Clear();
            Console.WriteLine(".::Registrar Estudiante::.");

            //Creamos el nuevo docente
            Estudiante nuevoEstudiante = new Estudiante();
            Console.Write("Nombre del Estudiante: ");
            nuevoEstudiante.Nombre = Console.ReadLine();
            Console.Write("Apellido del Estudiante: ");
            nuevoEstudiante.Apellido = Console.ReadLine();
            Console.Write("Numero de Estudiante: ");
            nuevoEstudiante.NIE = int.Parse(Console.ReadLine());

            //creamos el grado a cargo del docente
            Grado gradoAcargo = new Grado();
            Console.Write("Nombre del Grado: ");
            gradoAcargo.Nombre = Console.ReadLine();
            Console.Write("Sección del Grado: ");
            gradoAcargo.Seccion = Console.ReadLine();

            //asignamos el grado al nuevo docente
            nuevoEstudiante.GradoCursado = gradoAcargo;

            //agregamos el nuevo docente a la lista de docentes
            base.RegistrarEstudiante(nuevoEstudiante);

            //Mensaje de Guardado
            Console.WriteLine("Estudiante guardado con exito...");

            //hacemos la espera
            Console.ReadKey();
        }

        private void RegistrarDocente()
        {
            Console.Clear();
            Console.WriteLine(".::Registrar Docente::.");

            //Creamos el nuevo docente
            Docentes nuevoDocente = new Docentes();
            Console.Write("Nombre del Docente: ");
            nuevoDocente.Nombre = Console.ReadLine();
            Console.Write("Apellido del Docente: ");
            nuevoDocente.Apellido = Console.ReadLine();
            Console.Write("Numero de Escalafon: ");
            nuevoDocente.NumEscalafon = int.Parse(Console.ReadLine());

            //creamos el grado a cargo del docente
            Grado gradoAcargo = new Grado();
            Console.Write("Nombre del Grado: ");
            gradoAcargo.Nombre = Console.ReadLine();
            Console.Write("Sección del Grado: ");
            gradoAcargo.Seccion = Console.ReadLine();

            //asignamos el grado al nuevo docente
            nuevoDocente.GradoaCargo = gradoAcargo;

            //agregamos el nuevo docente a la lista de docentes
            base.RegistrarDocente(nuevoDocente);

            //Mensaje de Guardado
            Console.WriteLine("Docente guardado con exito...");

            //hacemos la espera
            Console.ReadKey();
        }

        /// <summary>
        /// Funcion sobrecargada
        /// </summary>
        /// <returns></returns>
        protected bool RegistrarDocente(int Docente)
        {
            return true;
        }
    }
}
