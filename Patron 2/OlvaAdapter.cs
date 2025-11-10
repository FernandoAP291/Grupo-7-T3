using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_2
{
    public class OlvaAdapter : IProveedorEnvio
    {
        private OlvaApi api = new OlvaApi();

        public string SolicitarRecogida(string direccion, double peso)
        {
            double pesoGramos = peso * 1000; // Convertir kg a gramos
            return api.RegistrarRecojo(direccion, pesoGramos);
        }

        public decimal CalcularCosto(double peso)
        {
            double pesoGramos = peso * 1000;
            return api.CalcularPrecio(pesoGramos);
        }
    }
}
