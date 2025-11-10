using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_2
{
    public class RappiApi
    {
        public string CrearSolicitud(string origen, double pesoKg)
        {
            return $"RAPPI-{new Random().Next(1000, 9999)}";
        }

        public double ObtenerTarifa(double pesoKg)
        {
            return pesoKg * 5.50;
        }
    }
}
