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
    public class PrecioProductoHistoricoServicioImpl : IPrecioProductoHistoricoServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IPrecioProductoHistoricoRepositorio _precioProducHist;

        public PrecioProductoHistoricoServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _precioProducHist = new PrecioProductoHistoricoRepositorioImpl(dbContext);
        }

        public async Task AddAsync(precio_producto_historico entidad)
        {
            await _precioProducHist.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _precioProducHist.DeleteAsync(id);
        }

        public Task<IEnumerable<precio_producto_historico>> GetAllAsync()
        {
            return _precioProducHist.GetAllAsync(); 
        }

        public Task<precio_producto_historico> GetByIdAsync(int id)
        {
            return _precioProducHist.GetByIdAsync(id);
        }

        public async Task UpdateAsync(precio_producto_historico entidad)
        {
            await _precioProducHist.UpdateAsync(entidad);
        }
    }
}
