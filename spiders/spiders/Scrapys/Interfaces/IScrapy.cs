using spiders.Models.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Scrapys.Interfaces
{
    public interface IScrapy
    {
        string NavegarPara(Categoria Categoria);
        List<Produto> Converter();
        List<Produto> Persistir(List<Produto> Produtos);
    }
}
