using DulceFacil.Aplicacion.Servicio;
using DulceFacil.Dominio.Modelo.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServicioImpl
{
    public class ProductoServicioImpl : IProductoServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IProductoRepositorio _productoRepositorio;

        public ProductoServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _productoRepositorio = new ProductoRepositorioImpl(dbContext);
        }

        public async Task AddAsync(producto entidad)
        {
            await _productoRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _productoRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<producto>> GetAllAsync()
        {
            return _productoRepositorio.GetAllAsync();
        }

        public Task<producto> GetByIdAsync(int id)
        {
            return _productoRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(producto entidad)
        {
            await _productoRepositorio.UpdateAsync(entidad);
        }
    }
}
