using DulceFacil.Aplicacion.Servicio;
using DulceFacil.Dominio.Modelo.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServicioImpl
{
    public class DireccionesServicioImpl : IDireccionesServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IDireccionesRepositorio _direccionesRepositorio;

        public DireccionesServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _direccionesRepositorio = new DireccionesRepositorioImpl(dbContext);
        }

        public async Task AddAsync(direciones entidad)
        {
            await _direccionesRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _direccionesRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<direciones>> GetAllAsync()
        {
            return _direccionesRepositorio.GetAllAsync();
        }

        public Task<direciones> GetByIdAsync(int id)
        {
            return _direccionesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(direciones entidad)
        {
            await _direccionesRepositorio.UpdateAsync(entidad);
        }
    }
}
