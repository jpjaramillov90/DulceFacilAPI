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
    public class EstadoPedidoServicioImpl : IEstadoPedidoServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IEstadoPedidoRepositorio _estadoPedidoRepositorio;

        public EstadoPedidoServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _estadoPedidoRepositorio = new EstadoPedidoRepositorioImpl(dbContext);
        }

        public async Task AddAsync(estado_pedido entidad)
        {
            await _estadoPedidoRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _estadoPedidoRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<estado_pedido>> GetAllAsync()
        {
            return _estadoPedidoRepositorio.GetAllAsync();
        }

        public Task<estado_pedido> GetByIdAsync(int id)
        {
            return _estadoPedidoRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(estado_pedido entidad)
        {
            await _estadoPedidoRepositorio.UpdateAsync(entidad);
        }
    }
}
