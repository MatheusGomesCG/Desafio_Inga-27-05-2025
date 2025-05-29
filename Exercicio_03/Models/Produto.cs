using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        private static List<Produto> produtos = new List<Produto>();

        public Produto()
        {
            
        }
        public Produto(int codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
        static public bool IsValidoCodigo(int codigo)
        {
            return produtos.Any(x => x.Codigo == codigo);
        }

        public void Adicionar(Produto p)
        {
            produtos.Add(p);
        }
        public bool Remover(int codigo)
        {

            var produtoRemover = produtos.Find(x => x.Codigo == codigo);
            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                return true;
            }
            return false;
        }
        public string BuscarPorCodigo(int codigo)
        {
            if (produtos.Any(x => x.Codigo == codigo))
            {
                StringBuilder sb = new StringBuilder();
                var produtoImprimir = produtos.Find(x => x.Codigo == codigo);

                sb.AppendLine($"Código do produto = {produtoImprimir.Codigo}");
                sb.AppendLine($"Nome do Produto = {produtoImprimir.Nome}");
                sb.AppendLine($"Preco do Produto = {produtoImprimir.Preco:C}");
                return sb.ToString();
            }

            return $"Produto não cadastrado";
        }

        public string ListarTodos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in produtos)
            {
                sb.AppendLine($"Código do produto = {item.Codigo}");
                sb.AppendLine($"Nome do Produto = {item.Nome}");
                sb.AppendLine($"Preco do Produto = {item.Preco:C}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}