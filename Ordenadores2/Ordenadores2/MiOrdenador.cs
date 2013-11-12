using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordenadores2
{
    class MiOrdenador
    {
        static void Main ( string [] args )
        {
            COrdenador miOrdenador = new COrdenador;
            miOrdenador.Marca = "Alienware";
            miOrdenador.EncenderOrdenador();
            miOrdenador.Estado();
           
        }
    }
}
