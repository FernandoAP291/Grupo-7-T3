using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_2
{
    public class RappiAdapter : IProveedorEnvio
    {
        private RappiApi api = new RappiApi();

        public string SolicitarRecogida(string direccion, double peso)
        {
            return api.CrearSolicitud(direccion, peso);
        }

        public decimal CalcularCosto(double peso)
        {
            return (decimal)api.ObtenerTarifa(peso);
        }
    }
}
