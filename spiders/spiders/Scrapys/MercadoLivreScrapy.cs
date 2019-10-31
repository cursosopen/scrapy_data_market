using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using spiders.Extensions;
using spiders.Models.Entitites;
using spiders.Services;

namespace spiders.Scrapys
{
    public class MercadoLivreScrapy : BaseScrapy
    {
        public MercadoLivreScrapy(string Pesquisa, Categoria Categoria) : base(Pesquisa, Categoria)
        {
        }

        public override List<Produto> Converter()
        {
            var Produtos = this.webDriver.FindElements(By.ClassName("rowItem"));
            return Produtos.Select(Produto => CriarPrduto(Produto)).ToList(); ;
        }

        private Produto CriarPrduto(IWebElement Produto)
        {
            try
            {
                var NomeProduto = Produto.FindElement(By.ClassName("item__title"));
                var PrecoContainer = Produto.FindElement(By.ClassName("item__price"));
                var ImagemContainer = Produto.FindElement(By.ClassName("images-viewer"));
                return new Produto()
                {
                    Nome = BuscarTitulo(NomeProduto),
                    Valor = FormatarPreco(PrecoContainer),
                    Imagem = BuscarImagem(ImagemContainer),
                    Id_Categoria = this.CategoriadeTrabalho.Id
                };
            }
            catch
            {
                return null;
            }
        }

        private static string BuscarTitulo(IWebElement NomeProduto)
        {
            List<string> Titles = new List<string>();
            Titles.Add(NomeProduto.TryFindElement(By.TagName("a"))?.Text);
            Titles.Add(NomeProduto.TryFindElement(By.ClassName("main-title"))?.Text);
            return Titles.Where(t => t != null).FirstOrDefault();
        }

        private string BuscarImagem(IWebElement imagemContainer)
        {
            var LinkImage = imagemContainer.FindElement(By.ClassName("image-content"))
                                           .FindElement(By.TagName("a"));
            var Image = LinkImage.FindElement(By.TagName("img"));

            if (Image.GetAttribute("src") != null)
               return Image.GetAttribute("src");
            else
               return Image.GetAttribute("data-src");
        }

        private decimal FormatarPreco(IWebElement PrecoContainer)
        {
            var Preco = PrecoContainer.FindElement(By.ClassName("price__fraction")).Text;
            var Decimal = PrecoContainer.TryFindElement(By.ClassName("price__decimals"))?.Text;

            return Decimal == null ? Convert.ToDecimal(Preco) : Convert.ToDecimal($"{Preco},{Decimal}");
        }

        public override string NavegarPara(Categoria Categoria)
        {
            return $"https://lista.mercadolivre.com.br/{this.Pesquisa}_DisplayType_LF#D[A:{this.Pesquisa}]";
        }

        public override List<Produto> Persistir(List<Produto> Produtos)
        {
            using (ProdutoService ProdutoService = new ProdutoService())
                return Produtos.Where(t => t != null)
                               .Select(Produto => {
                                   if (ProdutoService.BuscarProdutoPorNome(Produto) == null)
                                       ProdutoService.InserirProduto(Produto);
                                   return Produto;
                               }).ToList();
        }
    }
}
