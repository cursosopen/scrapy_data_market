namespace spiders.Models.Entitites
{
    public class Produto
    {
        public int Id { get; set; }
        public int Id_Categoria { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Imagem { get; set; }

        public Categoria Categoria { get; set; }
    }
}