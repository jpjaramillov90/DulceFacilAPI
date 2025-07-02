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
    public interface ICiudadesServicio
    {
        [OperationContract]
        Task AddAsync(ciudades entidad); // insetar
        [OperationContract]
        Task UpdateAsync(ciudades entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<ciudades>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<ciudades> GetByIdAsync(int id); // buscar por id   
    }
}
