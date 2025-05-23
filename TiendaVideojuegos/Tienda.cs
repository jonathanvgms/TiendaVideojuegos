namespace TiendaVideojuegos;

public class Tienda
{
    public List<Cliente> Clientes { get; set; }

    public Tienda()
    {
        Clientes = new List<Cliente>();
    }

    public void MostrarTotalesPorCliente()
    {
        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Cliente: {cliente.Nombre}");
            Console.WriteLine($"Total gastado: ${cliente.CalcularTotalGastado()}");
            Console.WriteLine("------------------------");
        }
    }
}