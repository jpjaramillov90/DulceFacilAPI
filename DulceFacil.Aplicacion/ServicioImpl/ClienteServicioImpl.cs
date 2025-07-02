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
    public class ClienteServicioImpl : IClienteServicio
    {
        private IClienteRepositorio _clienteRepositorio;
        private readonly db_dulce_facilContext _dbContext;

        public ClienteServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _clienteRepositorio = new ClienteRepositorioImpl(dbContext);
        }

        public async Task AddAsync(cliente entidad)
        {
            await _clienteRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _clienteRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<cliente>> GetAllAsync()
        {
            return _clienteRepositorio.GetAllAsync();
        }

        public Task<cliente> GetByIdAsync(int id)
        {
            return _clienteRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(cliente entidad)
        {
            await _clienteRepositorio.UpdateAsync(entidad);
        }
    }
}
