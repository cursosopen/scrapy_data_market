using spiders.Models.Entitites;
using spiders.Models.InfraEstructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Services
{
    public class ProdutoService : IDisposable
    {
        private DataBaseContext dataBaseContext;

        public ProdutoService()
        {
            this.dataBaseContext = new DataBaseContext();
        }

        public Produto BuscarProdutoPorNome(Produto Produto)
        {
            return (from Produtos in dataBaseContext.Produto
                    where Produtos.Nome == Produto.Nome
                    select Produtos).FirstOrDefault();
        }

        public Produto InserirProduto(Produto Produto)
        {
           return dataBaseContext.Produto.Add(Produto);
        }

        public void Dispose()
        {
            this.dataBaseContext.SaveChanges();
            this.dataBaseContext.Dispose();
        }
    }
}
