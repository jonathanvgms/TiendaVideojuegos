// Videojuegos disponibles
using TiendaVideojuegos;

var fifa = new Videojuego("FIFA 25", "Deportes", 70);
var gta = new Videojuego("GTA VI", "Acción", 100);
var zelda = new Videojuego("Zelda: Tears of the Kingdom", "Aventura", 80);

// Clientes
var cliente1 = new Cliente("Jonathan");
cliente1.Compras.Add(fifa);
cliente1.Compras.Add(gta);

var cliente2 = new Cliente("Lucía");
cliente2.Compras.Add(zelda);
cliente2.Compras.Add(gta);
cliente2.Compras.Add(fifa);

// Tienda
var tienda = new Tienda("GameVerse");
tienda.Clientes.Add(cliente1);
tienda.Clientes.Add(cliente2);

// Mostrar totales
tienda.MostrarTotalesPorCliente();