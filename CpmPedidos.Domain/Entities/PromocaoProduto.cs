using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain
{
    public class PromocaoProduto : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int IdImagem { get; set; }
        public virtual Imagem Imagem { get; set; }
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public bool Ativo { get; set; }
    }
}
