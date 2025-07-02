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
    public interface IDetallePedidoServicio
    {
        [OperationContract]
        Task AddAsync(detalle_pedido entidad); // insetar
        [OperationContract]
        Task UpdateAsync(detalle_pedido entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<detalle_pedido>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<detalle_pedido> GetByIdAsync(int id); // buscar por id
    }
}
