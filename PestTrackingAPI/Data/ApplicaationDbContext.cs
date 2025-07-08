using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<Usuario, Rol, int>
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
            .HasOne(e => e.Pais)
            .WithMany(p => p.Empresas)
            .HasForeignKey(e => e.IdPais);

        modelBuilder.Entity<Cultivo>()
            .HasOne(c => c.Empresa)
            .WithMany()
            .HasForeignKey(c => c.IdEmpresa);

        modelBuilder.Entity<Cultivo>()
            .HasOne(c => c.TipoCultivo)
            .WithMany(t => t.Cultivos)
            .HasForeignKey(c => c.IdTipoCultivo);

        modelBuilder.Entity<Canton>()
            .HasOne(c => c.Provincia)
            .WithMany(p => p.Cantones)
            .HasForeignKey(c => c.IdProvincia);

        modelBuilder.Entity<Distrito>()
            .HasOne(d => d.Canton)
            .WithMany(c => c.Distritos)
            .HasForeignKey(d => d.IdCanton);

        modelBuilder.Entity<CaracteristicaTipoCultivo>()
            .HasOne(ct => ct.TipoCultivo)
            .WithMany()
            .HasForeignKey(ct => ct.IdTipoCultivo);

        modelBuilder.Entity<CaracteristicaTipoCultivo>()
            .HasOne(ct => ct.Caracteristica)
            .WithMany()
            .HasForeignKey(ct => ct.IdCaracteristica);

        modelBuilder.Entity<Muestra>()
            .HasOne(m => m.Cultivo)
            .WithMany()
            .HasForeignKey(m => m.IdCultivo);
    }
}
