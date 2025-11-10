using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_I_grupo5.Patron_1
{
    public interface IObservadorPedido

    {
        void Actualizar(Pedido pedido, string estadoAnterior, string estadoNuevo);
    }

    public class NotificadorCliente : IObservadorPedido

    {
        public void Actualizar(Pedido pedido, string estadoAnterior, string estadoNuevo)
        {
            Console.WriteLine($" Notificando cliente: Pedido #{pedido.IdPedido} ahora está {estadoNuevo}");
        }
    }



    public class ActualizadorSistema : IObservadorPedido
    {
        public void Actualizar(Pedido pedido, string estadoAnterior, string estadoNuevo)
        {
            Console.WriteLine($" Sistema actualizado: Pedido #{pedido.IdPedido} → {estadoNuevo}");
        }

    }



    public class ActualizadorDashboard : IObservadorPedido
    {
        public void Actualizar(Pedido pedido, string estadoAnterior, string estadoNuevo)
        {
            Console.WriteLine($" Dashboard actualizado con estado: {estadoNuevo}");
        }
    }
}
