using InyeccionDeDependencias.Model;
using Microsoft.EntityFrameworkCore; 

namespace InyeccionDeDependencias.DataContext
{
    public class DataContextNorthwind : DbContext {

        public DataContextNorthwind(DbContextOptions<DataContextNorthwind> options) : base(options) {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}

                    