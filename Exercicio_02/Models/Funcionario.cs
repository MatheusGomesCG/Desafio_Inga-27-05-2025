using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        private static int idFuncionario = 1;
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public Funcionario()
        {

        }
        public Funcionario(string nome, decimal salario)
        {
            Id = idFuncionario;
            Nome = nome;
            Salario = salario;
            idFuncionario++;
        }
        public void AdicionarFuncionar(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }
        public bool AumentarSalario(int id, decimal percentual)
        {
            if (funcionarios.Any(x => x.Id == id))
            {
                var funcionarioPromovido = funcionarios.Find(x => x.Id == id);
                funcionarioPromovido.Salario *= 1 + (percentual / 100.00M);
                return true;
            }
            return false;
        }
        public bool ExisteFuncionario(int id)
        {
            if (funcionarios.Any(x => x.Id == id))
            {
                return true;
            }
            return false;
        }
        public string ExibirDados()
        {
            if (funcionarios.Count == 0)
            {
                return $"Não existe funcionarios cadastrados";
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in funcionarios)
            {
                sb.AppendLine($"Id = {item.Id}");
                sb.AppendLine($"Descrição = {item.Nome}");
                sb.AppendLine($"Salario = {item.Salario:C}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}