using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class Produto 
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    public class ClassesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.90);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);
            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("8ª Temporada Game of Throne", 99.90),
                new Produto("Poster", 10.00)
            };
            carrinho.AddRange(combo);

            MessageBox.Show($"Total de produtos no carrinho: {carrinho.Count}",
                "Carrinho de Compras",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            StringBuilder carrinhoString = new StringBuilder();

            foreach (var produto in carrinho)
            {
                carrinhoString.AppendLine($"- {produto.Nome} - Preço: {produto.Preco:F2}");
            }

            MessageBox.Show($"Produtos no carrinho:\n{carrinhoString}",
                    "Carrinho de Compras",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }
    }
}
