using EjemploSingleton.Patrones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton.AccesoDatos
{
    public class FuncConsola : clsBaseDatos
    {
        //declaracion de variables
        int OpcionSeleccionada = 0;

        //Creamos el menu principal
        private void MostrarMenu()
        {
            Console.WriteLine("     .::Sistema Academico::.   ");
            Console.WriteLine(" 1) Agregar Alumno");
            Console.WriteLine(" 2) Mostrar Alumno");
            Console.WriteLine(" 3) Eliminar Alumno");
            Console.WriteLine(" 4) Modificar Alumno");
            Console.WriteLine(" 5) Inscribir Materia");
            Console.WriteLine("=====================================");
            Console.WriteLine(" 6) Mostrar Docentes");
            Console.WriteLine(" 7) Mostrar Alumnos");
            Console.WriteLine(" 8) Mostrar Materias");
            Console.WriteLine(" 9) Salir");
            Console.Write("Ingrese su opción: ");
            this.OpcionSeleccionada = int.Parse(Console.ReadLine());
        }

        public void CicloApp()
        {
            //Creamos el ciclo
            do
            {
                //Limpiamos la consola
                Console.Clear();

                //Mostramos el menu de opciones
                this.MostrarMenu();


                switch (this.OpcionSeleccionada)
                {
                    case 1:

                        //Mostrar Alumno
                        RegistrarEstudiante();
                        break;
                    case 2:
                        //registrar Alumno
                        MostrarAlumno();
                        break;

                    case 3:

                        //Eliminar Alumno
                        DeleteAlumno();
                        break;

                    case 4:
                            //Modificar Alumno
                            ModificarAlumno();
                        break;

                    

                    case 5:
                        Console.WriteLine("Gracias por utilizar la aplicación... =]");
                        Console.ReadKey();
                        break;
                    default:
                        //Opcion invalida
                        Console.WriteLine("Ingrese una opcion valida...");
                        Console.ReadKey();
                        break;
                }

            } while (this.OpcionSeleccionada !=9);
        }

        private void ModificarAlumno()
        {
            //Limpiamos la consola
            Console.Clear();

            

            //Mostramos la lista alumno 
            this.MostrarAlumno();
            Console.Write("Eliga el ID del Alumno a Modificar: ");
            int IdAlumno = int.Parse(Console.ReadLine());

            //Obtenemos Alumno
            var AlumnoSel = Singleton.Instance.GetInstance.GetBaseDatos[IdAlumno  - 1];
            

            this.RegistrarEstudiante();
            Alumnos nuevoAlumno = new Alumnos();
            Console.Write("Numero del Alumno: ");
            nuevoAlumno.NIE = int.Parse(Console.ReadLine());
            Console.Write("Nombre del Alumno: ");
            nuevoAlumno.Nombre = Console.ReadLine();
            Console.Write("Apellido del Alumno: ");
            nuevoAlumno.Apellido = Console.ReadLine();
            Console.Write("Edad del Alumno: ");
            nuevoAlumno.Edad = int.Parse(Console.ReadLine());
            Console.Write("Grado del estudiante: ");
            nuevoAlumno.Grado = Console.ReadLine();

            Singleton.Instance.GetInstance.ModificarAlumno(AlumnoSel);  
            //Espera
            Console.ReadKey();
        }

        private void DeleteAlumno()
        {
            //Limpiamos la consola
            Console.Clear();

            //Mostrar la lista Alumno
            this.MostrarAlumno();
            Console.Write(" Eliga el ID del Alumno a Eliminar: ");
            int IdAlumno = int.Parse(Console.ReadLine());

            var AlumnoSel = Singleton.Instance.GetInstance.GetBaseDatos[IdAlumno - 1];

            Singleton.Instance.GetInstance.EliminarAlumno(AlumnoSel);
            //Eliminado
            Console.WriteLine("Elimando con exito");

            //Hacemos la espera
            Console.ReadKey();


        }

        private void RegistrarEstudiante()
        {
            //Limpiamos
            Console.Clear();

            Console.WriteLine(".::Resgistrar Alumno::.");


            //Creamos el nuevo alumno 
            Alumnos nuevoAlumno = new Alumnos();
            Console.Write("Numero del Alumno: ");
            nuevoAlumno.NIE = int.Parse(Console.ReadLine());
            Console.Write("Nombre del Alumno: ");
            nuevoAlumno.Nombre = Console.ReadLine();
            Console.Write("Apellido del Alumno: ");
            nuevoAlumno.Apellido = Console.ReadLine();
            Console.Write("Edad del Alumno: ");
            nuevoAlumno.Edad = int.Parse(Console.ReadLine());
            Console.Write("Grado del estudiante: ");
            nuevoAlumno.Grado = Console.ReadLine();

            //Agregamos alumno 
            Singleton.Instance.GetInstance.AgregarAlumno(nuevoAlumno);

            //Mensaje de guardar
            Console.WriteLine("Estudiante agregado con exito :/");

            //Hacemos la espera
            Console.ReadLine();
        }

        private void MostrarAlumno()
        {
            

            //Limpiamos la consola
            Console.Clear();

            Console.WriteLine(".:: L I S T A     A L U M N O ::.");


            //Recorremos la lista Alumnos
            int cont = 1;

            foreach (var Alumno in Singleton.Instance.GetInstance.GetBaseDatos)
            {
                //Imprimimos Alumno
                Console.WriteLine(" " + cont + ")" + "Nombre: " + Alumno.Nombre + " " + Alumno.Apellido + " ");



                cont++;
            }

            //Hacemos la espera
            Console.ReadKey();
        }
    }
}
