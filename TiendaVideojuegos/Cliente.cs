namespace TiendaVideojuegos;

public class Cliente
{
    public string Nombre { get; set; }
    public List<Videojuego> Compras { get; set; }

    public Cliente(string nombre)
    {
        Validador.ValidarCadenaNoVacia(nombre, nameof(Nombre));
        Nombre = nombre;
        Compras = new List<Videojuego>();
    }

    public double CalcularTotalGastado()
    {
        return Compras.Sum(juego => juego.Precio);
    }

    public void Comprar(List<Videojuego> videojuegos)
    {
        Compras.AddRange(videojuegos);
    }

    public void MostrarVideojuegos()
    {
        foreach (Videojuego videojuego in Compras)
        {
            Console.WriteLine($"Nombre: {videojuego.Nombre}");
            Console.WriteLine($"Genero: {videojuego.Genero}");
            Console.WriteLine($"Precio: {videojuego.Precio}");
        }
    }
}