using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_1
{
    public class GestorEventos
    {
        private Dictionary<string, List<IObservadorPedido>> listeners;
        public GestorEventos()
        {
            listeners = new Dictionary<string, List<IObservadorPedido>>();
        }



        public void Suscribir(string tipoEvento, IObservadorPedido observador)
        {
            if (!listeners.ContainsKey(tipoEvento))
            {
                listeners[tipoEvento] = new List<IObservadorPedido>();
            }
            listeners[tipoEvento].Add(observador);
        }



        public void Notificar(string tipoEvento, Pedido pedido, string estadoAnterior, string estadoNuevo)

        {
            if (listeners.ContainsKey(tipoEvento))
            {
                foreach (var observador in listeners[tipoEvento])
                {
                    observador.Actualizar(pedido, estadoAnterior, estadoNuevo);
                }
            }
        }
    }
}
