using EjemploSingleton.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton.Patrones
{
    public class Singleton
    {
        //Declaracion de variables
        private static Singleton _instance;
        private clsBaseDatos db;

        public static Singleton Instance{
            get{
                //Validamos si ya se encuentra instanciado el singleto
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Constructor Oculto del Singleton que permite inicializar
        /// los elementos globales
        /// </summary>
        private Singleton() {
            //inicializamos la base de datos
            this.db = new clsBaseDatos();
        }

        public clsBaseDatos GetInstance{
            get {
                return this.db;
            }
        }



    }
}
