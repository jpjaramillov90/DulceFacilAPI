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
    public interface IEstadoPedidoServicio
    {
        [OperationContract]
        Task AddAsync(estado_pedido entidad); // insetar
        [OperationContract]
        Task UpdateAsync(estado_pedido entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<estado_pedido>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<estado_pedido> GetByIdAsync(int id); // buscar por id   
    }
}
