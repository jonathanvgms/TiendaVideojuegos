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
}