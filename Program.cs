namespace LinqExercicio


{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Turma { get; set; }
        public List<int> Notas { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>
{
    new Produto { Id = 1, Nome = "Teclado", Categoria = "Periféricos",Preco = 29.90m, Stock = 12 },
    new Produto { Id = 2, Nome = "Rato", Categoria = "Periféricos", Preco = 15.50m, Stock = 0 },
    new Produto { Id = 3, Nome = "Monitor", Categoria = "Ecrãs", Preco = 189.99m, Stock = 4 },
    new Produto { Id = 4, Nome = "Portatil", Categoria ="Computadores",Preco = 899.00m, Stock = 2 },
    new Produto { Id = 5, Nome = "Webcam", Categoria = "Periféricos", Preco = 45.00m, Stock = 0 },
    new Produto { Id = 6, Nome = "Monitor 4K",Categoria = "Ecrãs",Preco = 349.50m, Stock = 7 },
    new Produto { Id = 7, Nome = "Desktop", Categoria ="Computadores",Preco = 649.00m, Stock = 5 }
};

            List<Aluno> alunos = new List<Aluno>
{
    new Aluno { Nome = "Ana", Idade = 19, Turma = "A", Notas = new List<int> { 14, 16, 11 } },
    new Aluno { Nome = "Bruno", Idade = 22, Turma = "B", Notas = new List<int> { 8, 12, 10 } },
    new Aluno { Nome = "Carlos", Idade = 19, Turma = "A", Notas = new List<int> { 18, 17, 19 } },
    new Aluno { Nome = "Diana", Idade = 25, Turma = "B", Notas = new List<int> { 9, 7, 13 } },
    new Aluno { Nome = "Eduardo",Idade = 21, Turma = "A", Notas = new List<int> { 15, 15, 14 } }
};

            //1. Liste os nomes de todos os produtos com preço inferior a 100 €.
            var produtosAbaixoDe100 = produtos
                .Where(produtos => produtos.Preco < 100);

            Console.WriteLine("Produtos com preço inferior a 100 €:");
            foreach (var produto in produtosAbaixoDe100)
            {
                Console.WriteLine(produto.Nome);
            }
            Console.WriteLine("================================");

            //2. Liste os produtos sem stock ( Stock == 0 ), mostrando apenas o nome.
            var produtosSemStock = produtos
                .Where(produtos => produtos.Stock == 0);
            Console.WriteLine("Produtos sem stock:");
            foreach (var produto in produtosSemStock)
            {
                Console.WriteLine(produto.Nome);

            }
            Console.WriteLine("================================");

            //3. Liste todos os produtos ordenados por preço, do mais caro para o mais barato.
            var produtosOrdenadosPorPreco = produtos
                .OrderByDescending(produtos => produtos.Preco);
            Console.WriteLine("Produtos ordenados por preço (do mais caro para o mais barato):");
            foreach (var produto in produtosOrdenadosPorPreco)
            {
                Console.WriteLine($"{produto.Nome} - {produto.Preco}$");
            }
            Console.WriteLine("================================");

            //4. Crie uma lista de strings no formato "Teclado — 29,90 €" para todos os produtos da categoria "Periféricos".
            List<String> produtosPerifericos = produtos
                .Where(produtos => produtos.Categoria == "Periféricos")
                .Select(produtos => $"{produtos.Nome} - {produtos.Preco}$").ToList();
            Console.WriteLine("Produtos da categoria 'Periféricos':");
            foreach (string produto in produtosPerifericos)
            {
                Console.WriteLine(produto);
            }
            Console.WriteLine("================================");

            //5. Calcule o valor total do stock em armazém (preço × stock, somado).
            var valorTotalStock = produtos
                .Sum(produtos => produtos.Preco * produtos.Stock);



        }
    }
}
