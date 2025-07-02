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
    public interface IRolesServicio
    {
        [OperationContract]
        Task AddAsync(roles entidad);
        [OperationContract]
        Task UpdateAsync(roles entidad);
        [OperationContract]
        Task DeleteAsync(int id);
        [OperationContract]
        Task<IEnumerable<roles>> GetAllAsync();
        [OperationContract]
        Task<roles> GetByIdAsync(int id);
    }
}
