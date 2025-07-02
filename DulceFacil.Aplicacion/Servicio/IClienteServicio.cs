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
    public interface IClienteServicio
    {
        [OperationContract]
        Task AddAsync(cliente entidad); // insetar
        [OperationContract]
        Task UpdateAsync(cliente entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<cliente>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<cliente> GetByIdAsync(int id); // buscar por id
    }
}
