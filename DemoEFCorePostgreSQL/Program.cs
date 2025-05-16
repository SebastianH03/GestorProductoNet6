using DemoEFCorePostgreSQL.Models;
using DemoEFCorePostgreSQL.Services;

var productoService = new ProductoService();

var nuevoProducto = new Producto
{
    Nombre = "Monitor MSI",
    Precio = "1000000"
};

await productoService.Crear(nuevoProducto);

var productos = await productoService.Listar();

Console.WriteLine("Listado de productos: ");
foreach (var producto in productos)
{
    Console.WriteLine($"ID: {producto.Id} | Nombre: {producto.Nombre} | Precio: ${producto.Precio}");
}

