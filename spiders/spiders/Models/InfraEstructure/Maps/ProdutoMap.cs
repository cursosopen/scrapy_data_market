using spiders.Models.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Models.InfraEstructure.Maps
{
    public class ProdutoMap : BaseMap<Produto>
    {
        public override void SetKey()
        {
            this.HasKey(t => t.Id);
        }

        public override void SetNameTable()
        {
            this.ToTable("Produto");
        }

        public override void SetProperties()
        {
            this.Property(t => t.Id).HasColumnName("Id").IsRequired();
            this.Property(t => t.Id_Categoria).HasColumnName("Id_Categoria").IsRequired();
            this.Property(t => t.Nome).HasColumnName("Nome").HasMaxLength(255).IsRequired();
            this.Property(t => t.Imagem).HasColumnName("Imagem").IsRequired();
            this.Property(t => t.Valor).HasColumnName("Valor").IsRequired();

        }

        public override void SetRelation()
        {
            HasRequired(t => t.Categoria).WithMany(t => t.Produtos).HasForeignKey(t => new { t.Id_Categoria });
        }
    }
}
