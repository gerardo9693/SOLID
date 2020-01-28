using System;
using System.IO;

namespace Eventos
{
    public class Archivo
    {
        public static void EscribirArchivo(string _cNombreEvento, DateTime _dtFechaEvento, string _cRuta)
        {
            StreamWriter write = new StreamWriter(_cRuta);
            write.Write(_cNombreEvento, _dtFechaEvento);
            write.Close();
        }

        public static string LeeArchivo(string _cRuta)
        {
            StreamReader read = new StreamReader(_cRuta);
            string contenido = read.ReadToEnd();
            read.Close();
            return contenido;
        }
    }
}
