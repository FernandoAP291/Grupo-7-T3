using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_3
{
    public class RutaEntrega
    {
        public List<string> Almacenes { get; set; }
        public List<string> Validaciones { get; set; }
        public string Transporte { get; set; }
        public bool TieneRevisionAduanera { get; set; }
        public string PuntoIntermedio { get; set; }

        public RutaEntrega()
        {
            Almacenes = new List<string>();
            Validaciones = new List<string>();
        }

        public override string ToString()
        {
            string resultado = "   Ruta: ";
            resultado += string.Join(" → ", Almacenes);
            if (!string.IsNullOrEmpty(PuntoIntermedio))
                resultado += $" → {PuntoIntermedio}";
            resultado += "\n   Validaciones: " + string.Join(", ", Validaciones);
            if (!string.IsNullOrEmpty(Transporte))
                resultado += $"\n   Transporte: {Transporte}";
            if (TieneRevisionAduanera)
                resultado += "\n  Con revisión aduanera";
            return resultado;
        }
    }
}
