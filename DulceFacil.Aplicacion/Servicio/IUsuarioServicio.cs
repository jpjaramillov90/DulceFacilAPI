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
    public interface IUsuarioServicio
    {
        [OperationContract]
        Task AddAsync(usuario entidad);
        [OperationContract]
        Task UpdateAsync(usuario entidad);
        [OperationContract]
        Task DeleteAsync(int id);
        [OperationContract]
        Task<IEnumerable<usuario>> GetAllAsync();
        [OperationContract]
        Task<usuario> GetByIdAsync(int id);
    }
}
