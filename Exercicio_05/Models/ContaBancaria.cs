using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05.Models
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inferior ou igual a zero!");
            }
            else
            {
                Saldo += valor;
                Console.WriteLine("Deposito realizado com sucesso!");
            }

        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine("Valor ou superior ao saldo ou menor ou igual a zero");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }

        }

        public string ExibirSaldo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Saldo:C}");

            return sb.ToString();
        }
    }
}