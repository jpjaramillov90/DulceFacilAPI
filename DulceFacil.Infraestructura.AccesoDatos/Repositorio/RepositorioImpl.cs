using DulceFacil.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly db_dulce_facilContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public RepositorioImpl(db_dulce_facilContext dbContex) { 
            _dbContext = dbContex;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task AddAsync(T entidad)
        {
            try 
            {
                await _dbSet.AddAsync(entidad); //inserta en las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se pudo insertar los datos, " + ex.Message);
            }
           
        }
        public async Task DeleteAsync(int id)
        {
            try
            {
                var entidad = await GetByIdAsync(id);
                _dbSet.Remove(entidad); //elimina el registro con el ID
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se pudo eliminar el dato, " + ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync(); //lista todos los datos
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron listar los datos, " + ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id); //buscar las tablas por id --siempre que sean números
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron listar con el ID especificado, " + ex.Message);
            }
        }

        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad); //actualiza las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se pudo insertar los datos, " + ex.Message);
            }
        }
    }
}
