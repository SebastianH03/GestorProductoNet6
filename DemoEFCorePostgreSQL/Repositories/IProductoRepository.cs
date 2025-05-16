using DemoEFCorePostgreSQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoEFCorePostgreSQL.Repositories
{
    public interface IProductoRepository
    {
        Task<List<Producto>> ObtenerTodos();
        Task AgregarProducto(Producto producto);
    }
}
