using Domain.Entidades.Cidades;
using Domain.Entidades.Disputas;
using Domain.Entidades.DominiosTerritorias;
using Domain.Entidades.Estados;
using Domain.Entidades.Girias;
using Domain.Entidades.RevoltasArmadas;
using Domain.Entidades.TratadosPazes;
using Domain.Entidades.Usuarios;
using Domain.Entidades.VotosDisputas;
using Domain.Entidades.VotosIntencoes;
using Microsoft.EntityFrameworkCore;

namespace INFRA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DominioTerritorial> DominioTerritorials { get; set; }
        public DbSet<Disputa> Disputa { get; set; }
        public DbSet<VotoDisputa> VotoDisputa { get; set; }
        public DbSet<RevoltaArmada> RevoltaArmada { get; set; }
        public DbSet<TratadoPaz> TratadoPaz { get; set; }
        public DbSet<VotoIntencao> VotoIntencao { get; set; }
        public DbSet<Giria> Giria { get; set; }
    }
}