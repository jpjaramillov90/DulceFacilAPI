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
    public class PrecioProductoServicioImpl : IPrecioProductoServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IPrecioProductoRepositorio _precioProducRepo;

        public PrecioProductoServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _precioProducRepo = new PrecioProductoRepositorioImpl(dbContext);
        }

        public async Task AddAsync(precio_producto entidad)
        {
            await _precioProducRepo.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _precioProducRepo.DeleteAsync(id);
        }

        public Task<IEnumerable<precio_producto>> GetAllAsync()
        {
            return _precioProducRepo.GetAllAsync();
        }

        public Task<precio_producto> GetByIdAsync(int id)
        {
            return _precioProducRepo.GetByIdAsync(id);
        }

        public async Task UpdateAsync(precio_producto entidad)
        {
            await _precioProducRepo.UpdateAsync(entidad);
        }
    }
}
