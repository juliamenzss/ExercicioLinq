namespace ExercicioLinq
{
    public class ExercicioLinqTests
    {
        private List<Produto> produtos;

        public ExercicioLinqTests()
        {
            produtos = new List<Produto>(); ;
            produtos.Add(new Produto { Nome = "Sab�o", Valor = 1.1m, Quantidade = 10 });
            produtos.Add(new Produto { Nome = "Detergente de prato", Valor = 10, Quantidade = 9 });
            produtos.Add(new Produto { Nome = "�gua", Valor = (decimal)8.2f, Quantidade = 8 });
            produtos.Add(new Produto { Nome = "Esponja", Valor = (decimal)5.5, Quantidade = 7 });
            produtos.Add(new Produto { Nome = "�gua sanit�ria", Valor = (decimal)30.30d, Quantidade = 6 });
            produtos.Add(new Produto { Nome = "Vassoura", Valor = 3.3m, Quantidade = 5 });
            produtos.Add(new Produto { Nome = "Desinfetante", Valor = 4.4m, Quantidade = 4 });
            produtos.Add(new Produto { Nome = "Pano de ch�o", Valor = 5.5m, Quantidade = 3 });
            produtos.Add(new Produto { Nome = "Purificador de �gua", Valor = 6.6m, Quantidade = 2 });
            produtos.Add(new Produto { Nome = "Balde", Valor = 10.1m, Quantidade = 1 });
        }


        [Fact(DisplayName = "Quantidade de produtos que possuem a palavra '�gua' no nome.")]
        public void Test1()
        {
            int quantidade = produtos.Count(p => p.Nome.Contains("�gua", StringComparison.CurrentCultureIgnoreCase));

            Assert.Equal(3, quantidade);
        }

        [Fact(DisplayName = "Produtos ordenados por nome.")]
        public void Test2()
        {
            IEnumerable<Produto> produtosOrdenados = produtos.OrderBy(p => p.Nome).ToList();

            Assert.Equal("�gua", produtosOrdenados.First().Nome);
            Assert.Equal("Vassoura", produtosOrdenados.Last().Nome);
        }

        [Fact(DisplayName = "Produtos ordenados do mais caro para o mais barato.")]
        public void Test3()
        {
            IEnumerable<Produto> produtosOrdenados = produtos.OrderByDescending(p => p.Valor).ToList();


            Assert.Equal("�gua sanit�ria", produtosOrdenados.First().Nome);
            Assert.Equal("Sab�o", produtosOrdenados.Last().Nome);
        }

        [Fact(DisplayName = "Produto mais caro")]
        public void Test4()
        {
            Produto produto = produtos.MaxBy(p => p.Valor);
            //Produto produto = produtos.OrderByDescending(p => (decimal)p.Valor).First();

            Assert.Equal("�gua sanit�ria", produto.Nome);
        }

        [Fact(DisplayName = "Produto mais barato")]
        public void Test5()
        {
            Produto produto = produtos.MinBy(p => p.Valor);

            Assert.Equal("Sab�o", produto.Nome);
        }

        [Fact(DisplayName = "Lista dos nomes dos produtoss")]
        public void Test6()
        {
            IEnumerable<string> nomeDosProdutos = produtos.Select(p => p.Nome).ToList();

            Assert.Contains("�gua", nomeDosProdutos);
        }

        [Fact(DisplayName = "Quantidade total de todos dos produtos")]
        public void Test7()
        {
            int quantidade = produtos.Sum(p => p.Quantidade);

            Assert.Equal(55, quantidade);
        }

        [Fact(DisplayName = "Nome dos produtos com valor at� 10.0")]
        public void Test8()
        {
            IEnumerable<string> nomeDosProdutos = produtos.Where(p => (int)p.Valor <= 10.0).Select(p => p.Nome);

            Assert.Contains("Detergente de prato", nomeDosProdutos);
            Assert.Contains("Sab�o", nomeDosProdutos);
        }

        [Fact(DisplayName = "Nome dos produtos com valor maior 10.0")]
        public void Test9()
        {
            IEnumerable<string> nomeDosProdutos = produtos.Where(p => (int)p.Valor >= 10.0).Select(p => p.Nome);

            Assert.Contains("Balde", nomeDosProdutos);
            Assert.Contains("�gua sanit�ria", nomeDosProdutos);
        }

        [Fact(DisplayName = "Verifica se o produto 'p�o' est� na lista")]
        public void Test10()
        {
            bool existe =  produtos.Any(p => p.Nome == "p�o");
            

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