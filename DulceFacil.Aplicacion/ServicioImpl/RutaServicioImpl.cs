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
    public class RutaServicioImpl : IRutaServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IRutaRepositorio _rutaRepositorio;

        public RutaServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _rutaRepositorio = new RutaRepositorioImpl(dbContext);
        }

        public async Task AddAsync(ruta entidad)
        {
            await _rutaRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _rutaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<ruta>> GetAllAsync()
        {
            return _rutaRepositorio.GetAllAsync();
        }

        public Task<ruta> GetByIdAsync(int id)
        {
            return _rutaRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(ruta entidad)
        {
            await _rutaRepositorio.UpdateAsync(entidad);
        }
    }
}
