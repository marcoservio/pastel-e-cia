using System.Data.Entity.ModelConfiguration;

namespace PastelECia.Models.Maps
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");
            HasKey(x => x.ClienteId);
            HasRequired(x => x.Cliente)
            .WithOptional(p => p.Endereco);
            Property(x => x.ClienteId).HasColumnName("ClienteId_end");
            Property(x => x.Locradouro).IsRequired().HasColumnName("Locradouro_end").HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Numero).IsRequired().HasColumnName("Numero_end").HasColumnType("int");
            Property(x => x.Complemento).HasColumnName("Complemento_end").HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Bairro).IsRequired().HasColumnName("Bairro_end").HasColumnType("varchar").HasMaxLength(60);
            Property(x => x.Cidade).IsRequired().HasColumnName("Cidade_end").HasColumnType("varchar").HasMaxLength(60);
            Property(x => x.Pais).IsRequired().HasColumnName("Pais_end").HasColumnType("varchar").HasMaxLength(40);
            Property(x => x.Estado).IsRequired().HasColumnName("Estado_end").HasColumnType("varchar").HasMaxLength(60);
            Property(x => x.Cep).IsRequired().HasColumnName("Cep_end").HasColumnType("varchar").HasMaxLength(8);
            Property(x => x.DataAlteracao).IsRequired().HasColumnName("DataAlteracao_end").HasColumnType("datetime");
            Property(x => x.Inativo).IsRequired().HasColumnName("Inativo_end");
        }
    }
}
