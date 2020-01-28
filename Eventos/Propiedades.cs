using System;

namespace Eventos
{
    public class Propiedades
    {
        private DateTime dtFechaEvento;
        private string cNombre;

        public void SetNombre(string _cNombre)
        {
            cNombre = _cNombre;
        }

        public string getNombre()
        {
            return cNombre;
        }

        public void SetFecha(DateTime _dtFecha)
        {
            //string cFecha = ""; 
            dtFechaEvento = _dtFecha;
           // _dtFecha = Convert.ToDateTime(cFecha);
        }

        public DateTime getFecha()
        {
            int result = DateTime.Compare(DateTime.Now, dtFechaEvento);
            DateTime fechaComp = DateTime.Parse("31/12/2019");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Ocurrió hace { result} horas");
                    break;
                case "2":
                    Console.WriteLine($"Ocurrió hace { result} días");
                    break;
                case "3":
                    Console.WriteLine($"Ocurrió hace { result} meses");
                    break;
                case "4":
                    Console.WriteLine($"Ocurrirá dentro de { result} horas");
                    break;
                case "5":
                    Console.WriteLine($"Ocurrirá dentro de { result} días");
                    break;
                case "6":
                    Console.WriteLine($"Ocurrirá dentro de { result} meses");
                    break;
                default:
                    break;
            }

            if ((result < 30) )
            {
                Console.WriteLine($"Ocurrió hace { dtFechaEvento} días"  );
            }

            //if (dtFechaEvento < DateTime.Now)
            //{
            //    Console.WriteLine();
            //}
            return dtFechaEvento;
        }


    }
}
