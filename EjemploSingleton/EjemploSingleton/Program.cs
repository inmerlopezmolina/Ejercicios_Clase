using EjemploSingleton.AccesoDatos;
using EjemploSingleton.Patrones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //Declarion de variable
            FuncConsola sysAlumno = new FuncConsola();

            //Ciclo de la aplicacion 
            sysAlumno.CicloApp();

            //Realizamos la espera
            Console.ReadKey();
        }
    }
}
