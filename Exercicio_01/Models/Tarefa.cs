using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        private static int idTarefa = 1;
        private static List<Tarefa> tarefas = new List<Tarefa>();

        public Tarefa()
        {
            
        }
        public Tarefa(string descricao)
        {
            Id = idTarefa;
            Descricao = descricao;
            Concluida = false;
            idTarefa++;
        }

        public void Adicionar(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public bool MarcarConcluida(int id)
        {
            if (tarefas.Any(x => x.Id == id))
            {
                var tarefaConcluida = tarefas.Find(x => x.Id == id);
                tarefaConcluida.Concluida = true;
                return tarefaConcluida.Concluida;
            }

            return false;
        }

        public string ListarTodas()
        {

            if (tarefas.Count == 0)
            {
                return $"Não existe tarefas cadastradas";
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in tarefas)
            {
                sb.AppendLine($"Id = {item.Id}");
                sb.AppendLine($"Descrição = {item.Descricao}");
                string atividadeConcluida = item.Concluida ? "Sim" : "Não";
                sb.AppendLine($"Concluída = {atividadeConcluida}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}