using System;

namespace Eventos.Services.Interfaces
{
    public interface IObtenerFecha
    {
        DateTime setFecha(string _cFecha);

        DateTime getFecha();
    }
}
