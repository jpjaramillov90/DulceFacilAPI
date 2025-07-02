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
    public interface ITipoClienteServicio
    {        
        [OperationContract]
        Task AddAsync(tipo_cliente entidad); // insetar
        [OperationContract]
        Task UpdateAsync(tipo_cliente entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<tipo_cliente>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<tipo_cliente> GetByIdAsync(int id); // buscar por id
    }
}
