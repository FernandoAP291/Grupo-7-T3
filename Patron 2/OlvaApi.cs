using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_2
{
    public class OlvaApi
    {
        public string RegistrarRecojo(string punto, double pesoGramos)
        {
            return $"OLVA-{new Random().Next(10000, 99999)}";
        }

        public decimal CalcularPrecio(double pesoGramos)
        {
            return (decimal)(pesoGramos / 1000 * 4.80);
        }
    }
}

