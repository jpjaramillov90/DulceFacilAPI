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
    public interface IProductoServicio
    {
        [OperationContract]
        Task AddAsync(producto entidad);
        [OperationContract]
        Task UpdateAsync(producto entidad);
        [OperationContract]
        Task DeleteAsync(int id);
        [OperationContract]
        Task<IEnumerable<producto>> GetAllAsync();
        [OperationContract]
        Task<producto> GetByIdAsync(int id);
    }
}
