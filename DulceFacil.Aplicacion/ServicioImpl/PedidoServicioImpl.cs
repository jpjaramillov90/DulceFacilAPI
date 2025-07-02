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
    public class PedidoServicioImpl : IPedidoServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IPedidoRepositorio _pedidoRepositorio;

        public PedidoServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _pedidoRepositorio = new PedidoRepositorioImpl(dbContext);
        }

        public async Task AddAsync(pedido entidad)
        {
            await _pedidoRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _pedidoRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<pedido>> GetAllAsync()
        {
            return _pedidoRepositorio.GetAllAsync();
        }

        public Task<pedido> GetByIdAsync(int id)
        {
            return _pedidoRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(pedido entidad)
        {
            await _pedidoRepositorio.UpdateAsync(entidad);
        }
    }
}
