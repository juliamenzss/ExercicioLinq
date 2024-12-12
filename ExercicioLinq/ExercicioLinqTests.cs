namespace ExercicioLinq
{
    public class ExercicioLinqTests
    {
        private List<Produto> produtos;

        public ExercicioLinqTests()
        {
            produtos = new List<Produto>(); 
            produtos.Add(new Produto { Nome = "Sabão", Valor = 1.1m, Quantidade = 10 });
            produtos.Add(new Produto { Nome = "Detergente de prato", Valor = 10, Quantidade = 9 });
            produtos.Add(new Produto { Nome = "Água", Valor = (decimal)8.2f, Quantidade = 8 });
            produtos.Add(new Produto { Nome = "Esponja", Valor = (decimal)5.5, Quantidade = 7 });
            produtos.Add(new Produto { Nome = "Água sanitária", Valor = (decimal)30.30d, Quantidade = 6 });
            produtos.Add(new Produto { Nome = "Vassoura", Valor = 3.3m, Quantidade = 5 });
            produtos.Add(new Produto { Nome = "Desinfetante", Valor = 4.4m, Quantidade = 4 });
            produtos.Add(new Produto { Nome = "Pano de chão", Valor = 5.5m, Quantidade = 3 });
            produtos.Add(new Produto { Nome = "Purificador de água", Valor = 6.6m, Quantidade = 2 });
            produtos.Add(new Produto { Nome = "Balde", Valor = 10.1m, Quantidade = 1 });
        }

        [Fact(DisplayName = "Quantidade de produtos que possuem a palavra 'água' no nome.")]
        public void Test1()
        {
            int quantidade = 0;

            Assert.Equal(3, quantidade);
        }

        [Fact(DisplayName = "Produtos ordenados por nome.")]
        public void Test2()
        {
            IEnumerable<Produto> produtosOrdenados = null;

            Assert.Equal("Água", produtosOrdenados.First().Nome);
            Assert.Equal("Vassoura", produtosOrdenados.Last().Nome);
        }

        [Fact(DisplayName = "Produtos ordenados do mais caro para o mais barato.")]
        public void Test3()
        {
            IEnumerable<Produto> produtosOrdenados = null;

            Assert.Equal("Água sanitária", produtosOrdenados.First().Nome);
            Assert.Equal("Sabão", produtosOrdenados.Last().Nome);
        }

        [Fact(DisplayName = "Produto mais caro")]
        public void Test4()
        {
            Produto produto = null;

            Assert.Equal("Água sanitária", produto.Nome);
        }

        [Fact(DisplayName = "Produto mais barato")]
        public void Test5()
        {
            Produto produto = null;

            Assert.Equal("Sabão", produto.Nome);
        }

        [Fact(DisplayName = "Lista dos nomes dos produtoss")]
        public void Test6()
        {
            IEnumerable<string> nomeDosProdutos = null;

            Assert.Contains("Água", nomeDosProdutos);
        }

        [Fact(DisplayName = "Quantidade total de todos dos produtos")]
        public void Test7()
        {
            int quantidade = 0;

            Assert.Equal(55, quantidade);
        }

        [Fact(DisplayName = "Nome dos produtos com valor até 10.0")]
        public void Test8()
        {
            IEnumerable<string> nomeDosProdutos = null;

            Assert.Contains("Detergente de prato", nomeDosProdutos);
            Assert.Contains("Sabão", nomeDosProdutos);
        }

        [Fact(DisplayName = "Nome dos produtos com valor maior 10.0")]
        public void Test9()
        {
            IEnumerable<string> nomeDosProdutos = null;

            Assert.Contains("Balde", nomeDosProdutos);
            Assert.Contains("Água sanitária", nomeDosProdutos);
        }

        [Fact(DisplayName = "Verifica se o produto 'pão' está na lista")]
        public void Test10()
        {
            bool existe = true;

            Assert.False(existe);
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}