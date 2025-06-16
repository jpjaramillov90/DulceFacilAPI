using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ClienteRepositorioImpl : RepositorioImpl<cliente>, IClienteRepositorio
    {
        public ClienteRepositorioImpl(db_dulce_facilContext dbContex) : base(dbContex)
        {
        }
    }
}
