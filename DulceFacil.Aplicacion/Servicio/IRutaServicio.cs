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
    public interface IRutaServicio
    {
        [OperationContract]
        Task AddAsync(ruta entidad);
        [OperationContract]
        Task UpdateAsync(ruta entidad);
        [OperationContract]
        Task DeleteAsync(int id);
        [OperationContract]
        Task<IEnumerable<ruta>> GetAllAsync();
        [OperationContract]
        Task<ruta> GetByIdAsync(int id);
    }
}
