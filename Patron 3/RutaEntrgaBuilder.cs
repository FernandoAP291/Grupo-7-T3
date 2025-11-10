using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_3
{
    public class RutaEntregaBuilder
    {
        private RutaEntrega ruta = new RutaEntrega();
        public RutaEntregaBuilder ConAlmacen(string almacen)
        {
            ruta.Almacenes.Add(almacen);
            return this;
        }

        public RutaEntregaBuilder ConValidacion(string validacion)
        {
            ruta.Validaciones.Add(validacion);
            return this;
        }

        public RutaEntregaBuilder ConTransporte(string transporte)
        {
            ruta.Transporte = transporte;
            return this;
        }

        public RutaEntregaBuilder ConRevisionAduanera()
        {
            ruta.TieneRevisionAduanera = true;
            return this;
        }

        public RutaEntregaBuilder ConPuntoIntermedio(string punto)
        {
            ruta.PuntoIntermedio = punto;
            return this;
        }

        public RutaEntrega Build()
        {
            return ruta;
        }
    }
}
