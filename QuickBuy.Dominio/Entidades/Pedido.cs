using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        
           

        //Variaveis de endereço deveriam ser em uma outra classe
        public String CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }







        //Collection, Pedido dever ter pelo menos um Item de pedido ou muitos item de pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedido.Any()) 
            {

                AdicionarCritica("Pedido não pode ser vazia");
            }

            if (string.IsNullOrEmpty(CEP)) 
            {
                AdicionarCritica("CEP não pode estar vazio");
            }
            if (FormaPagamentoId == 0) 
            {
                AdicionarCritica("Não foi informado a forma de pagamento"); 
            }
        }
    }
}
