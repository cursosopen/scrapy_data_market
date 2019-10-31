using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using spiders.Scrapys;
using spiders.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriaService CategoriaService = new CategoriaService();
            ExecutarSpiderMercadoLivre(CategoriaService);
        }

        private static void ExecutarSpiderMercadoLivre(CategoriaService categoriaService)
        {
            
            new MercadoLivreScrapy("lg-tv", categoriaService.BuscarCategoriaPorNome("Tv"));
            new MercadoLivreScrapy("oac-tv-led", categoriaService.BuscarCategoriaPorNome("Tv"));
            new MercadoLivreScrapy("philco-tv-hd", categoriaService.BuscarCategoriaPorNome("Tv"));

            new MercadoLivreScrapy("ps4-games", categoriaService.BuscarCategoriaPorNome("Games"));
            new MercadoLivreScrapy("xbox-one-games", categoriaService.BuscarCategoriaPorNome("Games"));
            new MercadoLivreScrapy("nintendo-switch-game", categoriaService.BuscarCategoriaPorNome("Games"));

            new MercadoLivreScrapy("moto-g", categoriaService.BuscarCategoriaPorNome("Celulares"));
            new MercadoLivreScrapy("xaomi", categoriaService.BuscarCategoriaPorNome("Celulares"));
            new MercadoLivreScrapy("lg", categoriaService.BuscarCategoriaPorNome("Celulares"));

            new MercadoLivreScrapy("livros -orientação-a-objetos", categoriaService.BuscarCategoriaPorNome("Livros"));
            new MercadoLivreScrapy("livro-algoritimos", categoriaService.BuscarCategoriaPorNome("Livros"));
            new MercadoLivreScrapy("livro-use-a-cabeça", categoriaService.BuscarCategoriaPorNome("Livros"));

            new MercadoLivreScrapy("mini-drone", categoriaService.BuscarCategoriaPorNome("Drones"));
            new MercadoLivreScrapy("grande-drone", categoriaService.BuscarCategoriaPorNome("Drones"));
            new MercadoLivreScrapy("drone-de-carga", categoriaService.BuscarCategoriaPorNome("Drones"));

            new MercadoLivreScrapy("pc-gamer", categoriaService.BuscarCategoriaPorNome("Informatica"));
            new MercadoLivreScrapy("teclados-mecanicos", categoriaService.BuscarCategoriaPorNome("Informatica"));
            new MercadoLivreScrapy("mouse-gamer", categoriaService.BuscarCategoriaPorNome("Informatica"));
            
        }
    }
}
