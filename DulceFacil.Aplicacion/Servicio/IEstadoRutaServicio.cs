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
    public interface IEstadoRutaServicio
    {
        [OperationContract]
        Task AddAsync(estado_ruta entidad); // insetar
        [OperationContract]
        Task UpdateAsync(estado_ruta entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<estado_ruta>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<estado_ruta> GetByIdAsync(int id); // buscar por id   
    }
}
