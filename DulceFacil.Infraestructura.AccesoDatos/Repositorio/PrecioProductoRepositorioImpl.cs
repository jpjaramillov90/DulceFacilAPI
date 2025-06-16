using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class PrecioProductoRepositorioImpl : RepositorioImpl<precio_producto>, IPrecioProductoRepositorio
    {
        public PrecioProductoRepositorioImpl(db_dulce_facilContext dbContex) : base(dbContex)
        {
        }
    }
}
