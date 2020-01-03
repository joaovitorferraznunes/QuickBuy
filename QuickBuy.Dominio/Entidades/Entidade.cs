using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        public List<string> MensagemValidacao
        {
         get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
    }
}
