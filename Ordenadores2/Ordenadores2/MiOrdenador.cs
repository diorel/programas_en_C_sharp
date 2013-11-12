using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordenadores2
{
    class MiOrdenador
    {
        // creamos un metodo main para la entrada y salida de datos
        static void Main ( string [] args )
        {
            COrdenador miOrdenador = new COrdenador;
            miOrdenador.Marca = "Alienware";
            miOrdenador.EncenderOrdenador();
            miOrdenador.Estado();
           
        }
    }
}
