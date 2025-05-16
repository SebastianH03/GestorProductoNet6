using DemoEFCorePostgreSQL.Models;
using DemoEFCorePostgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoEFCorePostgreSQL.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<List<Producto>> ObtenerTodos()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task AgregarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
        }
    }
}
