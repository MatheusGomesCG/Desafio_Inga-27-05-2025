using System;
using Exercicio_03.Models;

namespace Teste_Inga;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== MENU PRODUTOS ====");
            Console.WriteLine("[1] - ADICIONAR PRODUTO");
            Console.WriteLine("[2] - REMOVER PRODUTO");
            Console.WriteLine("[3] - LISTAR PRODUTO");
            Console.WriteLine("[4] - BUSCAR PRODUTO");
            Console.WriteLine("[5] - SAIR");
            Console.Write("Digite uma das opções: ");
            string choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("==== MENU ADICIONAR TAREFA ====");
                    Console.Write("Adicione o código do produto: ");
                    int codigo = IsValidInt(Console.ReadLine());

                    Console.Write("Adicione o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("Adicione o Preco do produto: R$ ");
                    decimal priceProduct = IsValidDecimal(Console.ReadLine());

                    Produto produto = new Produto(codigo, nome, priceProduct);
                    produto.Adicionar(produto);

                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("==== MENU REMOÇÃO PRODUTO ====");
                    Console.Write("Digite o código do produto que vai ser removido: ");
                    int idProduto = IsValidInt(Console.ReadLine());

                    string produtoRemovido = p.Remover(idProduto) ? "Produto removido com sucesso" : "Produto não encontrado";
                    Console.WriteLine(produtoRemovido);

                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("==== MENU DE PRODUTOS CADASTRADOS ====");
                    Console.WriteLine(p.ListarTodos());
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("==== MENU DE BUSCAR PRODUTOS ====");
                    Console.Write("Digite o código do produto que vai ser buscado: ");
                    int idProcurar = IsValidInt(Console.ReadLine());
                    Console.WriteLine(p.BuscarPorCodigo(idProcurar));
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!!! Digite qualquer tecla para voltar ao menu principal");
                    Console.ReadLine();
                    break;
            }
        }
        Console.WriteLine("Obrigado por usar o programa!!!");
    }

    static int IsValidInt(string inputUser)
    {
        bool sucess = int.TryParse(inputUser, out int number);
        while (!sucess)
        {
            Console.Write("Digite um número válido: ");
            sucess = int.TryParse(Console.ReadLine(), out number);
        }

        return number;
    }

    static decimal IsValidDecimal(string inputUser)
    {
        bool sucess = decimal.TryParse(inputUser, out decimal number);
        while (!sucess)
        {
            Console.Write("Digite um valor válido: ");
            sucess = decimal.TryParse(Console.ReadLine(), out number);
        }

        return number;
    }
}