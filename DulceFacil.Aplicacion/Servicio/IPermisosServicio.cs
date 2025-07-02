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
    public interface IPermisosServicio
    {
        [OperationContract]
        Task AddAsync(permisos entidad); // insetar
        [OperationContract]
        Task UpdateAsync(permisos entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<permisos>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<permisos> GetByIdAsync(int id); // buscar por id   
    }
}
