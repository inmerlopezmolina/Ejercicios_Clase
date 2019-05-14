using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysAcademico.Modelo;

namespace SysAcademico
{
    class Program
    {

        static void Main(string[] args)
        {
            //declaracion de variables
            FuncConsola sysAcademicoConsola = new FuncConsola();

            //Ciclo de la aplicación
            sysAcademicoConsola.CicloApp();

            //Realizamos la espera
            Console.ReadKey();
        }
    }
}
