using InyeccionDeDependencias.Model;

namespace InyeccionDeDependencias.Repository
{
    public interface INorthwindRepository
    {
        Task<List<Employees>> ObtenerTodosLosEmpleados();

        Task<int> ObtenerCantidadEmpleados();

        Task<Employees> ObtenerEmpleadoPorID(int id);

        Task<Employees> ObtenerEmpleadoPorNombre(string nombreEmpleado);

        Task<Employees> ObtenerIDEmpleadoPorTitulo(string titulo);

        Task<Employees> ObtenerIDEmpleadoPorPais(string Country);

        Task<List<Employees>> ObtenerTodosLosEmpleadoPorPais(string Country);

        Task<Employees> ObtenerElEmpleadoMasGrande(); 

    }
}
