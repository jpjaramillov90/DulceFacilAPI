using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.Servicio
{
    [ServiceContract]
    public interface IPrecioProductoHistoricoServicio
    {
        [OperationContract]
        Task AddAsync(precio_producto_historico entidad); // insetar
        [OperationContract]
        Task UpdateAsync(precio_producto_historico entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<precio_producto_historico>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<precio_producto_historico> GetByIdAsync(int id);
    }
}
