using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using spiders.Models.Entitites;
using spiders.Scrapys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Scrapys
{
    public abstract class BaseScrapy : IScrapy
    {
        protected Categoria CategoriadeTrabalho;
        protected IWebDriver webDriver;
        protected string Pesquisa;

        public BaseScrapy(string Pesquisa, Categoria Categoria)
        {
            this.webDriver = new ChromeDriver();
            this.Pesquisa = Pesquisa;
            this.CategoriadeTrabalho = Categoria;
            FluxoExecucao();
            this.webDriver.Quit();
        }

        private void FluxoExecucao()
        {
            webDriver.Navigate().GoToUrl(this.NavegarPara(this.CategoriadeTrabalho));
            webDriver.Manage().Window.Maximize();
            var Produtos = this.Converter();
            this.Persistir(Produtos);
        }

        public abstract string NavegarPara(Categoria Categoria);
        public abstract List<Produto> Converter();
        public abstract List<Produto> Persistir(List<Produto> Produtos);
    }
}
