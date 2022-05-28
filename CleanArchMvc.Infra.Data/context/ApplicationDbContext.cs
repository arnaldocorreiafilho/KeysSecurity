using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Infra.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

      

        public DbSet<Keys> Keys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
//dotnet ef database update -s /home/arnald0/projeto/KeysSecurity/CleanArchMvc.WebUI/ -p /home/arnald0/projeto/KeysSecurity/CleanArchMvc.Infra.Data/
//<YourStrong@Passw0rd>