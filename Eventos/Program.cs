using Eventos.Services.Interfaces;
using System;
using System.IO;

namespace Eventos
{
    public class Program
    {
        private readonly ILeerArchivo _leerArchivo;
        private readonly IObtenerFecha _obtenerFecha;
        private readonly IObtenerNombre _obtenerNombre;

        public Program(ILeerArchivo leerArchivo, IObtenerNombre obtenerNombre  , IObtenerFecha obtenerFecha )
        {
            _leerArchivo = leerArchivo ?? throw new ArgumentNullException(nameof(leerArchivo));
            _obtenerNombre = obtenerNombre ?? throw new ArgumentNullException(nameof(obtenerNombre));
            _obtenerFecha = obtenerFecha ?? throw new ArgumentNullException(nameof(obtenerFecha));
        }


        public string ObtenerDatos(string cRuta)
        {
            string cRutaArchivo = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            StreamReader read = new StreamReader(cRutaArchivo + cRuta);
            _leerArchivo.LeerArchivo(read.ToString());
            string contenido = read.ReadToEnd();
            read.Close();
            return contenido;
        }

       
        public static void Main(string[] args)
        {
   //         StreamReader file = new StreamReader(@"C:\Usuarios\gerardo.ku\Desktop\Eventos.txt");
           
            Propiedades _propiedades = new Propiedades();
            Console.WriteLine("Evento:");
            _propiedades.SetNombre(Console.ReadLine());
            //Console.WriteLine("Fecha Evento: ");

            //_propiedades.SetFecha(Console.ReadLine());
           // Console.WriteLine(_propiedades.getFecha());
            Console.ReadKey();

           // Archivo.EscribirArchivo(_propiedades.getNombre(), _propiedades.getFecha(), file.ToString());
           // Archivo.LeeArchivo(file.ToString());          
        }

       
    }
}
