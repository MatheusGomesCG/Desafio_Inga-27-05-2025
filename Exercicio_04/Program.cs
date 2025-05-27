using System;
using Exercicio_04.Models;

namespace Teste_Inga;

class Program
{
    static void Main(string[] args)
    {
        Pedido p = new Pedido();

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== MENU PEDIDO ====");
            Console.WriteLine("[1] - Adicionar Pedido");
            Console.WriteLine("[2] - Calcular preço total");
            Console.WriteLine("[3] - Sair");
            Console.Write("Digite uma das opções: ");
            string choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("==== MENU CADASTRO ====");
                    Console.Write("Digite o nome do produto: ");
                    string nameProduct = Console.ReadLine();

                    Console.Write("Digite a quantidade do produto: ");
                    int quantity = IsValidInt(Console.ReadLine());

                    Console.Write("Digite o preço unitário do produto: R$ ");
                    decimal priceProduct = IsValidDecimal(Console.ReadLine());

                    ItemPedido itemPedido = new ItemPedido(nameProduct, quantity, priceProduct);
                    p.AdicionarPedido(itemPedido);

                    Console.WriteLine("Produto cadastrado com sucesso!!!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("==== MENU CALCULO FINAL DO PEDIDO ====");
                    Console.WriteLine($"O valor final do pedido é: {p.CalcularTotal():C}");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!!! Digite qualquer tecla para voltar ao menu principal");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Obrigado por usar o programa!!!!");
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