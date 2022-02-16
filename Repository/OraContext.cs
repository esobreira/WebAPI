using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class OraContext : DbContext
    {
        public OraContext() : base("name=OracleDbContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Anexos> Anexos  { get; set; }
        public DbSet<Binarios> Binarios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Model.Produtos> Produtos { get; set; }
        public DbSet<Model.Pedidos> Pedidos { get; set; }
        public DbSet<Model.Pedidos_Itens> Pedidos_Itens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SOBREIRA");

            base.OnModelCreating(modelBuilder);
        }

        
    }
}
