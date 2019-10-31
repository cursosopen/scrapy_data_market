using spiders.Models.Entitites;
using spiders.Models.InfraEstructure;
using spiders.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Services
{
    public class CategoriaService : ICategoriaService
    {
        public List<Categoria> BuscarCategorias()
        {
            using (DataBaseContext DataBaseContext = new DataBaseContext())
                return DataBaseContext.Categoria.ToList();
        }

        public Categoria BuscarCategoriaPorNome(string Nome)
        {
            using (DataBaseContext DataBaseContext = new DataBaseContext())
            {
                return DataBaseContext.Categoria.Where(t => t.Nome == Nome)
                                                 .FirstOrDefault();
            }
        }
    }
}
