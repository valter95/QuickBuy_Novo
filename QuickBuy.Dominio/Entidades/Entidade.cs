using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public abstract class Entidade
    {
        public List<string> _mensagem { get; set; }
        public List<string> MensagemValidacao
        {
            get { return _mensagem ?? (_mensagem = new List<string>()); }
        }
        protected void LimparMensagensValidacao() 
        {
            MensagemValidacao.Clear();
        
        }

        protected void AdicionarCritica(string Mensagem) 
        {
            MensagemValidacao.Add(Mensagem);
        }
        public abstract void Validate();
        protected bool EhValido 
        {
            get { return !MensagemValidacao.Any(); }
        }


    }
}
