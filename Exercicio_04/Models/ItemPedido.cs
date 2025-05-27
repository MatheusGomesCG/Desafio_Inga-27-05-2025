using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_04.Models
{
    public class ItemPedido
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        

        public ItemPedido()
        {

        }
        public ItemPedido(string nomeProduto, int quantidade, decimal precoUnitario)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }



    }
}