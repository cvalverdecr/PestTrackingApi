using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<Usuario,Rol, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Pais> Paises { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<TipoCultivo> TiposCultivo { get; set; }
    public DbSet<Cultivo> Cultivos { get; set; }
    public DbSet<Provincia> Provincias { get; set; }
    public DbSet<Canton> Cantones { get; set; }
    public DbSet<Distrito> Distritos { get; set; }
    public DbSet<Caracteristica> Caracteristicas { get; set; }
    public DbSet<CaracteristicaTipoCultivo> CaracteristicasTipoCultivo { get; set; }
    public DbSet<Muestra> Muestras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Empresa>()
            .HasOne<Pais>()
            .WithMany()
            .HasForeignKey(e => e.IdPais);

        modelBuilder.Entity<Canton>()
            
            .HasOne<Provincia>()
            .WithMany()
            .HasForeignKey(c => c.IdProvincia);

        modelBuilder.Entity<Distrito>()
            .HasOne<Canton>()
            .WithMany()
            .HasForeignKey(d => d.IdCanton);

        modelBuilder.Entity<CaracteristicaTipoCultivo>()
            .HasOne<TipoCultivo>()
            .WithMany()
            .HasForeignKey(ctc => ctc.IdTipoCultivo);

        modelBuilder.Entity<CaracteristicaTipoCultivo>()
            .HasOne<Caracteristica>()
            .WithMany()
            .HasForeignKey(ctc => ctc.IdCaracteristica);

        modelBuilder.Entity<Cultivo>()
            .HasOne<Empresa>()
            .WithMany()
            .HasForeignKey(c => c.IdEmpresa);

        modelBuilder.Entity<Cultivo>()
            .HasOne<TipoCultivo>()
            .WithMany()
            .HasForeignKey(c => c.IdTipoCultivo);

        modelBuilder.Entity<Muestra>()
            .HasOne<Cultivo>()
            .WithMany()
            .HasForeignKey(m => m.IdCultivo);

        modelBuilder.Entity<Muestra>()
            .HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(m => m.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Muestra>()
            .HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(m => m.IdUsuarioModificacion)
            .OnDelete(DeleteBehavior.Restrict);
    }
}