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
    public class ProvinciasServicioImpl : IProvinciasServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IProvinciasRepositorio _provinciasRepositorio;

        public ProvinciasServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _provinciasRepositorio = new ProvinciasRepositorioImpl(dbContext);
        }

        public async Task AddAsync(provincias entidad)
        {
            await _provinciasRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _provinciasRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<provincias>> GetAllAsync()
        {
            return _provinciasRepositorio.GetAllAsync();
        }

        public Task<provincias> GetByIdAsync(int id)
        {
            return _provinciasRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(provincias entidad)
        {
            await _provinciasRepositorio.UpdateAsync(entidad);
        }
    }
}
