namespace TiendaVideojuegos;

public class Videojuego
{
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public double Precio { get; set; }

    public Videojuego(string nombre, string genero, double precio)
    {
        Validador.ValidarCadenaNoVacia(nombre, nameof(Nombre));
        Validador.ValidarCadenaNoVacia(genero, nameof(Genero));
        Validador.ValidarNumeroNoNegativo(precio, nameof(Precio));

        Nombre = nombre;
        Genero = genero;
        Precio = precio;
    }
}