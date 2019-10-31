using spiders.Models.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Models.InfraEstructure.Maps
{
    public class CategoriaMap : BaseMap<Categoria>
    {
        public override void SetKey()
        {
            this.HasKey(t => t.Id);
        }

        public override void SetNameTable()
        {
            this.ToTable("Categoria");
        }

        public override void SetProperties()
        {
            this.Property(t => t.Id).HasColumnName("Id").IsRequired();
            this.Property(t => t.Nome).HasColumnName("Nome").HasMaxLength(255).IsRequired();
        }

        public override void SetRelation()
        {
            HasMany(t => t.Produtos).WithRequired(t => t.Categoria).HasForeignKey(t => new { t.Id_Categoria });
        }
    }
}
