using DulceFacil.Aplicacion.Servicio;
using DulceFacil.Dominio.Modelo.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServicioImpl
{
    public class CiudadesServicioImpl : ICiudadesServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private ICiudadesRepositorio _ciudadesRepositorio;

        public CiudadesServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _ciudadesRepositorio = new CiudadesRepositorioImpl(dbContext);
        }

        public async Task AddAsync(ciudades entidad)
        {
            await _ciudadesRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _ciudadesRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<ciudades>> GetAllAsync()
        {
            return _ciudadesRepositorio.GetAllAsync();
        }

        public Task<ciudades> GetByIdAsync(int id)
        {
            return _ciudadesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(ciudades entidad)
        {
            await _ciudadesRepositorio.UpdateAsync(entidad);
        }
    }
}
