using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoCEEM.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }

        public DbSet<Consumo> Consumos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<MotivoInativacao> MotivoInativacoes { get; set; }
        public DbSet<OrdemServico> OrdemServicos { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<PreCadastro> PreCadastros { get; set; }
        public DbSet<Sensor> Sensores { get; set; }
        public DbSet<StatusOrdemServico> StatusOrdemServicos { get; set; }
        public DbSet<StatusUsuario> StatusUsuarios { get; set; }
        public DbSet<TipoContato> TipoContatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}