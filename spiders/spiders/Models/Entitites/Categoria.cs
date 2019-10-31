using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Models.Entitites
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
