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
    public class UsuarioServicioImpl : IUsuarioServicio
    {
        private readonly db_dulce_facilContext _dbContext;
        private IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServicioImpl(db_dulce_facilContext dbContext)
        {
            this._dbContext = dbContext;
            _usuarioRepositorio = new UsuarioRepositorioImpl(dbContext);
        }

        public async Task AddAsync(usuario entidad)
        {
            await _usuarioRepositorio.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _usuarioRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<usuario>> GetAllAsync()
        {
            return _usuarioRepositorio.GetAllAsync();
        }

        public Task<usuario> GetByIdAsync(int id)
        {
            return _usuarioRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateAsync(usuario entidad)
        {
            await _usuarioRepositorio.UpdateAsync(entidad);
        }
    }
}
