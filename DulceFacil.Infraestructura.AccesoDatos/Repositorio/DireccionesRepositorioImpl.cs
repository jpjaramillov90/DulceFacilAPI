using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class DireccionesRepositorioImpl : RepositorioImpl<direciones>, IDireccionesRepositorio
    {
        public DireccionesRepositorioImpl(db_dulce_facilContext dbContex) : base(dbContex)
        {
        }
    }
}
