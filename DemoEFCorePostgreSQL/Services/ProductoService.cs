using DemoEFCorePostgreSQL.Models;
using DemoEFCorePostgreSQL.Repositories;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DemoEFCorePostgreSQL.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService()
        {
            _repository = new ProductoRepository();
        }

        public async Task<List<Producto>> Listar()
        {
            return await _repository.ObtenerTodos();
        }

        public async Task Crear(Producto producto)
        {

            var productosExistentes = await _repository.ObtenerTodos();

            if (productosExistentes.Any(p => p.Nombre == producto.Nombre)) 
            {
                throw new Exception("Ya existe un producto con este nombre");
            }

            await _repository.AgregarProducto(producto);
        }
    }
}
