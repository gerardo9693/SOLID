using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Services.Interfaces
{
    public interface IObtenerNombre
    {
        void setNombre(string _cNombre);

        string getNombre();

    }
}
