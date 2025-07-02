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
    public class EstadoRutaServicioImpl : IEstadoRutaServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IEstadoRutaRepositorio _estadoRutaRepositorio;

        public EstadoRutaServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _estadoRutaRepositorio = new EstadoRutaRepositorioImpl(dbContext);
        }

        public async Task AddAsync(estado_ruta entidad)
        {
            await _estadoRutaRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _estadoRutaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<estado_ruta>> GetAllAsync()
        {
            return _estadoRutaRepositorio.GetAllAsync();
        }

        public Task<estado_ruta> GetByIdAsync(int id)
        {
            return _estadoRutaRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(estado_ruta entidad)
        {
            await _estadoRutaRepositorio.UpdateAsync(entidad);
        }
    }
}
