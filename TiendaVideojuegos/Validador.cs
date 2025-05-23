namespace TiendaVideojuegos;

public static class Validador
{
    public static void ValidarCadenaNoVacia(string valor, string nombreCampo)
    {
        if (string.IsNullOrWhiteSpace(valor))
        {
            throw new ArgumentException($"El campo '{nombreCampo}' no puede estar vacío o solo contener espacios.");
        }
    }

    public static void ValidarNumeroNoNegativo(double valor, string nombreCampo)
    {
        if (valor < 0)
        {
            throw new ArgumentException($"El campo '{nombreCampo}' no puede ser un valor negativo.");
        }
    }
}