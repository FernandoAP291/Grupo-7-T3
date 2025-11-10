using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_1
{
    public class Pedido
    {
        public GestorEventos eventos;
        public string IdPedido { get; set; }
        public string Cliente { get; set; }
        public string EstadoActual { get; private set; }

        public Pedido(string idPedido, string cliente)
        {
            this.IdPedido = idPedido;
            this.Cliente = cliente;
            this.EstadoActual = "Creado";
            this.eventos = new GestorEventos();
        }


        public void CambiarEstado(string nuevoEstado)
        {
            string estadoAnterior = EstadoActual;
            EstadoActual = nuevoEstado;
            Console.WriteLine($"\n Pedido #{IdPedido}: {estadoAnterior} → {nuevoEstado}");
            eventos.Notificar(nuevoEstado, this, estadoAnterior, nuevoEstado);
        }
    }
}
