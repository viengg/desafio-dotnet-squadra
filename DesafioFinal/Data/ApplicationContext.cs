using DesafioFinal.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinal.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Curso>(e =>
            {
                e.ToTable("Clientes");
                e.HasKey(p => p.Id);
                e.Property(p => p.Titulo).HasColumnType("varchar(40)").IsRequired();
                e.Property(p => p.StatusCurso).HasConversion<string>().IsRequired();
                e.Property(p => p.Duracao).HasDefaultValue(60);
            });
        }

        public DbSet<Curso> Curso { get; set; }
    }
}
