using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_2
{
    public interface IProveedorEnvio
    {
        string SolicitarRecogida(string direccion, double peso);
        decimal CalcularCosto(double peso);
    }

    
}
