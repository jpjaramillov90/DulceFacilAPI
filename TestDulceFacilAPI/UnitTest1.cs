using DulceFacil.Aplicacion.Servicio;
using DulceFacil.Aplicacion.ServicioImpl;
using DulceFacil.Dominio.Modelo.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TestDulceFacilAPI
{
    public class Tests
    {
        private IClienteServicio _clienteServicio;
        private ITipoClienteServicio _tipoClienteServicio;
        private db_dulce_facilContext _dbdulce_facilContext;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<db_dulce_facilContext>()
                .UseSqlServer("Data Source=JOAOJV;Initial Catalog=db_dulce_facil;Persist Security Info=True;User ID=sa;Password=Angul4r23;TrustServerCertificate=True;")
                .Options;
            _dbdulce_facilContext = new db_dulce_facilContext(options);
            _tipoClienteServicio = new TipoClienteServicioImpl(_dbdulce_facilContext);
            _clienteServicio = new ClienteServicioImpl(_dbdulce_facilContext);
        }

        [Test]
        public async Task TestDulceFacilAPI()
        {
            //var tipoCLiente = new tipo_cliente { tipo_cliente1 = "Minorista" };
            //await _tipoClienteServicio.AddAsync(tipoCLiente);
            //var result = await _tipoClienteServicio.GetAllAsync();
            //Console.WriteLine(result);

            var client = new cliente { id_tipo_cliente = 1, nombres = "Joao", apellidos = "Jaramillo", telefono = "0999944605", correo = "jjaramillo@gmail.com" };
            await _clienteServicio.AddAsync(client);
            Assert.Pass();
        }
        [TearDown] //borra todo al terminar el test
        public void afterTest()
        {
            _dbdulce_facilContext.Dispose();
        }
    }
}