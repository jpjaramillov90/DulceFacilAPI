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
    public class TipoClienteServicioImpl : ITipoClienteServicio
    {
        private ITipoClienteRepositorio _tipoClienteRepositorio;
        private readonly db_dulce_facilContext _dbContext;

        public TipoClienteServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _tipoClienteRepositorio = new TipoClienteRepositorioImpl(dbContext);
        }

        public async Task AddAsync(tipo_cliente entidad)
        {
            await _tipoClienteRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _tipoClienteRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<tipo_cliente>> GetAllAsync()
        {
            return _tipoClienteRepositorio.GetAllAsync();
        }

        public Task<tipo_cliente> GetByIdAsync(int id)
        {
            return _tipoClienteRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(tipo_cliente entidad)
        {
            await _tipoClienteRepositorio.UpdateAsync(entidad);
        }
    }
}
