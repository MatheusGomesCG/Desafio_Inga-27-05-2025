using System;
using Exercicio_02.Models;

namespace Teste_Inga;

class Program
{
    static async Task Main(string[] args)
    {
        Funcionario func = new Funcionario();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== MENU CADASTRO FUNCIONARIO ====");
            Console.WriteLine("[1] - CADASTRAR FUNCIONÁRIO");
            Console.WriteLine("[2] - AUMENTAR SALÁRIO DO FUNCIONÁRIO");
            Console.WriteLine("[3] - EXIBIR FUNCIONÁRIOS");
            Console.WriteLine("[4] - SAIR");
            Console.Write("Digite uma das opções: ");
            string choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("==== MENU CADASTRO FUNCIONARIO ====");
                    Console.Write("Digite o nome do funcionário: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o salário do funcionário: R$ ");
                    decimal salary = IsValidDecimal(Console.ReadLine());

                    Funcionario funcionario = new Funcionario(nome, salary);
                    funcionario.AdicionarFuncionar(funcionario);
                    Console.WriteLine($"O funcionário {nome} foi cadastrado com sucesso!! O Id é {funcionario.Id}");
                    await Task.Delay(2000);
                    break;
                case "2":
                    Console.WriteLine("==== MENU PROMOÇÃO FUNCIONÁRIO ====");
                    Console.Write("Digite o Id do funcionário que vai receber o aumento: ");
                    if (int.TryParse(Console.ReadLine(), out int numberId) && func.ExisteFuncionario(numberId))
                    {
                        Console.Write("Digite a % do valor do aumento: ");
                        decimal percentageSalary = IsValidDecimal(Console.ReadLine());
                        func.AumentarSalario(numberId, percentageSalary);
                        Console.WriteLine("Salário foi aumentado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Id não encontrado");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("==== MENU DE FUNCIONARIOS CADASTRADOS ====");
                    Console.WriteLine(func.ExibirDados());
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

        Console.WriteLine("Obrigado por usar o programa!!!!");
    }

    static decimal IsValidDecimal(string inputUser)
    {
        bool sucess = decimal.TryParse(inputUser, out decimal number);
        while (!sucess || number <= 0)
        {
            Console.Write("Digite um valor válido: ");
            sucess = decimal.TryParse(Console.ReadLine(), out number);
        }
        return number;
    }
}