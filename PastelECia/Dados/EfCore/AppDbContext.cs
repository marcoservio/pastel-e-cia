﻿using PastelECia.Models.Maps;

using System.Data.Entity;
using System.Reflection;
using System.Security.Policy;

namespace PastelECia.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Data Source=MARCOSERVIO\\SQLEXPRESS;Initial Catalog=Pastel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<VersaoSistema> VersaoSistema { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new VersaoSistemaMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
        }
    }
}