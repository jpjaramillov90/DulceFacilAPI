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
    internal class PermisosServicioImpl : IPermisosServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IPermisosRepositorio _permisosRepositorio;

        public PermisosServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _permisosRepositorio = new PermisosRepositorioImpl(dbContext);
        }

        public async Task AddAsync(permisos entidad)
        {
            await _permisosRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _permisosRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<permisos>> GetAllAsync()
        {
            return _permisosRepositorio.GetAllAsync();
        }

        public Task<permisos> GetByIdAsync(int id)
        {
            return _permisosRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(permisos entidad)
        {
            await _permisosRepositorio.UpdateAsync(entidad);
        }
    }
}
