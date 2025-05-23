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

    public string ObtenerPresentacion()
    {
        return $"Yo soy {Nombre}, un {Genero} cargado de acción y mi precio es: {Precio:C} monedas";
    }

    public double AplicarDescuento(double valorDescuento) //valorDescuento son valores de 0 a 100
    {
        return Precio - Precio * valorDescuento / 100;
    }

    public bool SosDelGenero(string nombreGenero)
    {
        return nombreGenero.Trim().ToLower() == Genero.Trim().ToLower();
    }
}