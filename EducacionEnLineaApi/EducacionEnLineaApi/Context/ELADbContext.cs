using EducacionEnLineaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EducacionEnLineaApi.Context
{
    public class ELADbContext: DbContext
    {

        public ELADbContext(DbContextOptions<ELADbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar el esquema predeterminado
            modelBuilder.HasDefaultSchema("EducacionEnLineaSchema");

            // Configurar las relaciones entre las entidades
            modelBuilder.Entity<ProgramaEducativo>()
                .HasOne(p => p.AreaAcademica)
                .WithMany()
                .HasForeignKey(p => p.IdAreaAcademica);

            modelBuilder.Entity<ProgramaEducativo>()
                .HasOne(p => p.Grado)
                .WithMany()
                .HasForeignKey(p => p.IdGrado);

            modelBuilder.Entity<ExperienciaEducativa>()
                .HasOne(e => e.ProgramaEducativo)
                .WithMany()
                .HasForeignKey(e => e.IdProgramaEducativo);

            modelBuilder.Entity<ExpertosEnEE>()
                .HasOne(e => e.ExperienciaEducativa)
                .WithMany()
                .HasForeignKey(e => e.IdExperienciaEducativa);

            modelBuilder.Entity<ExpertosEnEE>()
                .HasOne(e => e.ExpertoContenido)
                .WithMany()
                .HasForeignKey(e => e.IdExperto);
        }

        public DbSet<AreaAcademica> AreasAcademicas { get; set; }
        public DbSet<ExperienciaEducativa> ExperienciasEducativas { get; set; }
        public DbSet<ExpertoContenido> ExpertosContenido { get; set; }
        public DbSet<ExpertosEnEE> ExpertosEnEEs { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<ProgramaEducativo> ProgramasEducativos { get; set; }
        public DbSet<Region> Regiones { get; set; }
    }
}
