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
    public class DetallePedidoServicioImpl : IDetallePedidoServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IDetallePedidoRepositorio _detallePedidoRepo;

        public DetallePedidoServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _detallePedidoRepo = new DetallePedidoRepositorioImpl(dbContext);
        }

        public async Task AddAsync(detalle_pedido entidad)
        {
            await _detallePedidoRepo.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _detallePedidoRepo.DeleteAsync(id);
        }

        public Task<IEnumerable<detalle_pedido>> GetAllAsync()
        {
            return _detallePedidoRepo.GetAllAsync();
        }

        public Task<detalle_pedido> GetByIdAsync(int id)
        {
            return _detallePedidoRepo.GetByIdAsync(id);
        }

        public async Task UpdateAsync(detalle_pedido entidad)
        {
            await _detallePedidoRepo.UpdateAsync(entidad);
        }
    }
}
