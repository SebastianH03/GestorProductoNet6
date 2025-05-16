using DemoEFCorePostgreSQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoEFCorePostgreSQL.Services
{
    public interface IProductoService
    {
        Task<List<Producto>> Listar();
        Task Crear(Producto producto);
    }
}
