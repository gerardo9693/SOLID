using System;

namespace Eventos.Business.Conversions
{
    public class Convert
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
            dtFechaEvento = _dtFecha;
        }


        public DateTime getFecha()
        {
            int result = DateTime.Compare(DateTime.Now, dtFechaEvento);
            DateTime fechaComp = DateTime.Parse("31/12/2019");

            if ((result < 30))
            {
                Console.WriteLine($"Ocurrió hace { dtFechaEvento} días");
            }

            return dtFechaEvento;
        }

        public void getMessage(int result)
        {
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
        }
    }
}
