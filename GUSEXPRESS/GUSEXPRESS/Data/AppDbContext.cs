using GUSEXPRESS.Models;
using Microsoft.EntityFrameworkCore;

namespace GUSEXPRESS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Destinatario> Destinatarios { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<EstadoEnvio> EstadoEnvios { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Envios)
                .WithOne(e => e.Usuarios)
                .HasForeignKey(e => e.UsuarioID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Destinatarios)
                .WithOne(d => d.Usuarios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Destinatario>()
                .HasMany(d => d.Envios)
                .WithOne(e => e.Destinatarios)
                .HasForeignKey(e => e.DestinatarioId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<EstadoEnvio>()
                .HasMany(ee => ee.Envios)
                .WithOne(e => e.EstadoEnvios)
                .HasForeignKey(e => e.EstadoEnvioId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
