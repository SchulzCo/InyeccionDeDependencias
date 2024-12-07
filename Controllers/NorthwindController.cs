using InyeccionDeDependencias.EjemploConDY;
using InyeccionDeDependencias.Model;
using InyeccionDeDependencias.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.CompilerServices;

namespace InyeccionDeDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private readonly INorthwindRepository _Repository;

        public NorthwindController(INorthwindRepository Repository) {

            _Repository = Repository;
        }

        [HttpGet]
        [Route("api/TodosLosEmpleados")]
        public async Task<List<Employees>> ObtenerTodosLosEmpleados()
        {
            return await _Repository.ObtenerTodosLosEmpleados();

        }

        [HttpGet]
        [Route("api/CantidadEmpleados")]
        public async Task<int> ObtenerCantidadEmpleados()
        {
            return await _Repository.ObtenerCantidadEmpleados();

        }


        [HttpGet]
        [Route("api/EmpleadosPorID")]
        public async Task<Employees> EmpleadosPorID([FromQuery] int empleadoID)
        {
            return await _Repository.ObtenerEmpleadoPorID(empleadoID);

        }


        [HttpGet]
        [Route("api/EmpleadoPorNombre")]
        public async Task<Employees> ObtenerEmpleadoPorNombre([FromQuery] string nombreEmpleado)
        {
            return await _Repository.ObtenerEmpleadoPorNombre(nombreEmpleado);

        }


        [HttpGet]
        [Route("api/IDEmpleadoPorTitulo")]
        public async Task<Employees> ObtenerIDEmpleadoPorTitulo([FromQuery] string titulo)
        {
            return await _Repository.ObtenerIDEmpleadoPorTitulo(titulo);

        }

        [HttpGet]
        [Route("api/IDEmpleadoPorPais")]
        public async Task<Employees> ObtenerIDEmpleadoPorPais(string Country)
       
        {
            return await _Repository.ObtenerIDEmpleadoPorPais(Country);

        }

        [HttpGet]
        [Route("api/TodosLosEmpleadoPorPais")]
        public async Task<List<Employees>> ObtenerTodosLosEmpleadoPorPais(string Country)

        {
            return await _Repository.ObtenerTodosLosEmpleadoPorPais(Country);

        }

        [HttpGet]
        [Route("api/ElEmpleadoMasGrande")]
        public async Task<Employees> ObtenerElEmpleadoMasGrande()

        {
            return await _Repository.ObtenerElEmpleadoMasGrande();

        }
    }
}
