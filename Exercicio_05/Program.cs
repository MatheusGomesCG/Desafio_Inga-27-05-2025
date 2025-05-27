using System;
using Exercicio_05.Models;

namespace Teste_Inga;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        Console.Write("Digite o número da conta: ");
        conta.NumeroConta = Console.ReadLine();

        Console.Write("Digite o Saldo da conta: ");
        conta.Saldo = IsValidDecimal(Console.ReadLine());

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== MENU CONTA BANCARIA ====");
            Console.WriteLine("[1] - DEPOSITAR");
            Console.WriteLine("[2] - SACAR");
            Console.WriteLine("[3] - EXIBIR SALDO");
            Console.WriteLine("[4] - SAIR");
            string choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("==== MENU DEPOSITAR ====");
                    Console.Write("Digite o valor do deposito: R$ ");
                    decimal valorDeposito = IsValidDecimal(Console.ReadLine());
                    conta.Depositar(valorDeposito);

                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("==== MENU SACAR ====");
                    Console.Write("Digite o valor do saque: R$ ");
                    decimal valorSaque = IsValidDecimal(Console.ReadLine());
                    conta.Sacar(valorSaque);

                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("==== MENU EXIBIR SALDO ====");
                    Console.WriteLine(conta.ExibirSaldo());
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!!! Digite qualquer tecla para voltar ao menu principal");
                    Console.ReadLine();
                    break;
            }
        }
        Console.WriteLine("Obrigado por usar o sistema!!!");
    }
    static decimal IsValidDecimal(string inputUser)
    {
        bool sucess = decimal.TryParse(inputUser, out decimal number);
        while (!sucess || number < 0)
        {
            Console.Write("Digite um valor válido: ");
            sucess = decimal.TryParse(Console.ReadLine(), out number);
        }

        return number;
    }
}