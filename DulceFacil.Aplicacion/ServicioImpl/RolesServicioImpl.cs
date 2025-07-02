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
    public class RolesServicioImpl : IRolesServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IRolesRepositorio _rolesRepositorio;

        public RolesServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _rolesRepositorio = new RolesRepositorioImpl(dbContext);
        }

        public async Task AddAsync(roles entidad)
        {
            await _rolesRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _rolesRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<roles>> GetAllAsync()
        {
            return _rolesRepositorio.GetAllAsync();
        }

        public Task<roles> GetByIdAsync(int id)
        {
            return _rolesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(roles entidad)
        {
            await _rolesRepositorio.UpdateAsync(entidad);
        }
    }
}
