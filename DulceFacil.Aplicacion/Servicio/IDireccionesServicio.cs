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
    public interface IDireccionesServicio
    {
        [OperationContract]
        Task AddAsync(direciones entidad); // insetar
        [OperationContract]
        Task UpdateAsync(direciones entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<direciones>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<direciones> GetByIdAsync(int id); // buscar por id   
    }
}
