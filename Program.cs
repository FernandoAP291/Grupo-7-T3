using Patron_de_Diseño_I_grupo5.Patron_1;
using Patron_de_Diseño_I_grupo5.Patron_2;
using Patron_de_Diseño_I_grupo5.Patron_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║          SISTEMA LOGIPACK S.A.C.                           ║");
            Console.WriteLine("║     Demostración de Patrones de Diseño                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            // ========================================
            // 1. PATRÓN OBSERVER
            // ========================================
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.WriteLine("  PATRÓN 1: OBSERVER - Notificaciones Automáticas");
            Console.WriteLine("═══════════════════════════════════════════════════════════════\n");

            // Crear pedido
            Pedido pedido = new Pedido("P001", "Juan Pérez");

            // Suscribir observadores
            pedido.eventos.Suscribir("Validado", new NotificadorCliente());
            pedido.eventos.Suscribir("Validado", new ActualizadorSistema());

            pedido.eventos.Suscribir("En Ruta", new NotificadorCliente());
            pedido.eventos.Suscribir("En Ruta", new ActualizadorDashboard());

            pedido.eventos.Suscribir("Entregado", new NotificadorCliente());
            pedido.eventos.Suscribir("Entregado", new ActualizadorSistema());
            pedido.eventos.Suscribir("Entregado", new ActualizadorDashboard());

            // Cambiar estados (las notificaciones se envían automáticamente)
            pedido.CambiarEstado("Validado");
            pedido.CambiarEstado("En Ruta");
            pedido.CambiarEstado("Entregado");

            // ========================================
            // 2. PATRÓN ADAPTER
            // ========================================
            Console.WriteLine("\n\n═══════════════════════════════════════════════════════════════");
            Console.WriteLine("  PATRÓN 2: ADAPTER - Integración con Proveedores");
            Console.WriteLine("═══════════════════════════════════════════════════════════════\n");

            // Usar diferentes proveedores con la misma interfaz
            IProveedorEnvio rappi = new RappiAdapter();
            IProveedorEnvio olva = new OlvaAdapter();

            Console.WriteLine(" Enviando con RappiEnvios:");
            string guiaRappi = rappi.SolicitarRecogida("Av. Larco 1234, Lima", 2.5);
            decimal costoRappi = rappi.CalcularCosto(2.5);
            Console.WriteLine($"  Guía: {guiaRappi}");
            Console.WriteLine($"  Costo: S/ {costoRappi:F2}");

            Console.WriteLine("\n📦 Enviando con Olva Courier:");
            string guiaOlva = olva.SolicitarRecogida("Jr. Cusco 567, Ayacucho", 3.0);
            decimal costoOlva = olva.CalcularCosto(3.0);
            Console.WriteLine($"  ✓ Guía: {guiaOlva}");
            Console.WriteLine($"  ✓ Costo: S/ {costoOlva:F2}");

            // ========================================
            // 3. PATRÓN BUILDER
            // ========================================
            Console.WriteLine("\n\n═══════════════════════════════════════════════════════════════");
            Console.WriteLine("  PATRÓN 3: BUILDER - Constructor de Rutas Flexibles");
            Console.WriteLine("═══════════════════════════════════════════════════════════════\n");

            // Ruta simple (nacional)
            Console.WriteLine("🛣️  Ruta Nacional Simple:");
            RutaEntrega rutaSimple = new RutaEntregaBuilder()
                .ConAlmacen("Almacén N1")
                .ConValidacion("DNI")
                .ConTransporte("Olva Courier")
                .Build();
            Console.WriteLine(rutaSimple);

            // Ruta compleja (internacional)
            Console.WriteLine("\n🛣️  Ruta Internacional Compleja:");
            RutaEntrega rutaCompleja = new RutaEntregaBuilder()
                .ConAlmacen("Almacén N1")
                .ConAlmacen("Almacén N3")
                .ConValidacion("Pasaporte")
                .ConValidacion("Declaración Aduanera")
                .ConTransporte("DHL Express")
                .ConRevisionAduanera()
                .ConPuntoIntermedio("Aduana Callao")
                .Build();
            Console.WriteLine(rutaCompleja);

            // Ruta sin transporte (recojo en tienda)
            Console.WriteLine("\n🛣️  Ruta Recojo en Tienda:");
            RutaEntrega rutaRecojo = new RutaEntregaBuilder()
                .ConAlmacen("Almacén N4")
                .ConValidacion("DNI")
                .Build();
            Console.WriteLine(rutaRecojo);

            // ========================================
            // RESUMEN
            // ========================================
            Console.WriteLine("\n\n═══════════════════════════════════════════════════════════════");
            Console.WriteLine("  RESUMEN DE PATRONES APLICADOS");
            Console.WriteLine("═══════════════════════════════════════════════════════════════\n");

            Console.WriteLine("✅ OBSERVER:");
            Console.WriteLine("   • Notificaciones automáticas al cambiar estados");
            Console.WriteLine("   • Clientes, sistemas y dashboards actualizados sin código manual\n");

            Console.WriteLine("✅ ADAPTER:");
            Console.WriteLine("   • Integración con APIs incompatibles de proveedores");
            Console.WriteLine("   • Sistema usa misma interfaz para todos los proveedores\n");

            Console.WriteLine("✅ BUILDER:");
            Console.WriteLine("   • Construcción flexible de rutas con componentes opcionales");
            Console.WriteLine("   • Código limpio y fácil de mantener\n");

            Console.WriteLine("═══════════════════════════════════════════════════════════════\n");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}