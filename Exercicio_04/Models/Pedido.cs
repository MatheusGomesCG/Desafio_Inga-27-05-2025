using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_04.Models
{
    public class Pedido
    {
        private static List<ItemPedido> pedido = new List<ItemPedido>();
        public void AdicionarPedido(ItemPedido itemPedido)
            {
                pedido.Add(itemPedido);
            }

            public decimal CalcularTotal()
            {
                if (pedido.Count == 0)
                {
                    return 0.0M;
                }
                decimal valueTotal = 0.0M;
                foreach (var item in pedido)
                {
                    valueTotal += item.Quantidade * item.PrecoUnitario;
                }

                return valueTotal;
            }
    }

}