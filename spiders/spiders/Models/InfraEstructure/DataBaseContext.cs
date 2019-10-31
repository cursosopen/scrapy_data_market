using spiders.Models.Entitites;
using spiders.Models.InfraEstructure.Maps;
using spiders.Models.InfraEstructure.SeedData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Models.InfraEstructure
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CategoriaSeed());
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
    }
}
