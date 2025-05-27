using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Exercicio_01.Models;

namespace Teste_Inga;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        Tarefa t = new Tarefa();
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== MENU CADASTRO TAREFAS ====");
            Console.WriteLine("[1] - CADASTRAR NOVA TAREFA");
            Console.WriteLine("[2] - MARCAR TAREFA COMO CONCLUÍDA");
            Console.WriteLine("[3] - LISTAR TODAS AS TAREFAS");
            Console.WriteLine("[4] - SAIR");
            Console.Write("Digite uma das opções: ");
            string choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("==== MENU ADICIONAR TAREFA ====");
                    Console.Write("Adicione o nome da tarefa: ");
                    string nomeTarefa = Console.ReadLine();
                    Tarefa tarefa = new Tarefa(nomeTarefa);
                    tarefa.Adicionar(tarefa);
                    Console.WriteLine($"Sua {tarefa.Descricao} foi cadastrada com sucesso! Com Id: {tarefa.Id}");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("==== MENU CONCLUIR TAREFA ====");
                    Console.Write("Digite o Id da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int numberId) && t.MarcarConcluida(numberId))
                    {
                        Console.WriteLine("Tarefa Concluída");
                    }
                    else
                    {
                        Console.WriteLine("Id não encontrado");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("==== MENU DE TAREFAS CADASTRADAS ====");
                    Console.WriteLine(t.ListarTodas());
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção incorreta!!!");
                    break;
            }

        }

        Console.WriteLine("Obrigado por usar o programa!!!");
    }
    
}