namespace TiendaVideojuegos;

public class Tienda
{
    public string Nombre { get; set; }
    public List<Cliente> Clientes { get; set; }

    public Tienda(string nombre)
    {
        Validador.ValidarCadenaNoVacia(nombre, nameof(nombre));
        Nombre = nombre;
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

    public void Buscar(string nombreCliente)
    {
        var clienteEncontrado = Clientes.Find(cliente => cliente.Nombre == nombreCliente);

        if (clienteEncontrado is not null)
        {
            Console.WriteLine(clienteEncontrado.Nombre);

            foreach (Videojuego juego in clienteEncontrado.Compras)
            {
                Console.WriteLine(juego.Nombre);
            }
        }
        else
        {
            Console.WriteLine($"El cliente {nombreCliente} no se encuentra en nuestra lista de Clientes");
        }
    }
}