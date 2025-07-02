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
    public interface IPedidoServicio
    {
        [OperationContract]
        Task AddAsync(pedido entidad); // insetar
        [OperationContract]
        Task UpdateAsync(pedido entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<pedido>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<pedido> GetByIdAsync(int id); // buscar por id   
    }
}
