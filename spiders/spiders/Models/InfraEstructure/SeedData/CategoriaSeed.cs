using spiders.Models.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Models.InfraEstructure.SeedData
{
    public class CategoriaSeed : DropCreateDatabaseAlways<DataBaseContext>
    {
        public CategoriaSeed()
        {
        }

        protected override void Seed(DataBaseContext context)
        {
            IList<Categoria> CategoriasDefault = new List<Categoria>();

            CategoriasDefault.Add(new Categoria() { Nome = "Tv" });
            CategoriasDefault.Add(new Categoria() { Nome = "Games" });
            CategoriasDefault.Add(new Categoria() { Nome = "Celulares" });
            CategoriasDefault.Add(new Categoria() { Nome = "Livros" });
            CategoriasDefault.Add(new Categoria() { Nome = "Drones" });
            CategoriasDefault.Add(new Categoria() { Nome = "Informatica" });

            context.Categoria.AddRange(CategoriasDefault);

            base.Seed(context);
        }
    }
}
