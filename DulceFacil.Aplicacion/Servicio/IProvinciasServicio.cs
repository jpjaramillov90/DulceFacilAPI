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
    public interface IProvinciasServicio
    {
        [OperationContract]
        Task AddAsync(provincias entidad);
        [OperationContract]
        Task UpdateAsync(provincias entidad);
        [OperationContract]
        Task DeleteAsync(int id);
        [OperationContract]
        Task<IEnumerable<provincias>> GetAllAsync();
        [OperationContract]
        Task<provincias> GetByIdAsync(int id);
    }
}
