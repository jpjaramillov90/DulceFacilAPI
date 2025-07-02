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
    public interface IPrecioProductoServicio
    {
        [OperationContract]
        Task AddAsync(precio_producto entidad); // insetar
        [OperationContract]
        Task UpdateAsync(precio_producto entidad); // actualizar
        [OperationContract]
        Task DeleteAsync(int id); // eliminar
        [OperationContract]
        Task<IEnumerable<precio_producto>> GetAllAsync(); // listar (select * from)
        [OperationContract]
        Task<precio_producto> GetByIdAsync(int id);
    }
}
