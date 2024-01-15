using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeWorks.Models;

namespace SafeWorksWEB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<Capacitacion> Capacitacion { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ReportarAccidente> ReportarAccidente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<AsesoriaEspecial> AsesoriaEspecial { get; set; }
        public DbSet<Asesoria> Asesoria { get; set; }
        public DbSet<WorkerLocationDto> WorkerLocationDto { get; set; }

    }
}