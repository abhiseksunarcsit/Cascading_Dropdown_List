using Cascading_Dropdown_List.Models.Cascade;
using Microsoft.EntityFrameworkCore;


namespace Cascading_Dropdown_List.Data
{
    public class CascadeContext:DbContext
    {
        public CascadeContext(DbContextOptions<CascadeContext> options):base(options)
        {

        }
        public DbSet<County> Counties { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
