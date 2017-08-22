using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOPedido
    {
        [DataMember(), Key(), Required()]
        public int Id { get; set; }

        [DataMember(), Required(), StringLength(10)]
        public string Codigo { get; set; }

        [DataMember(), Required()]
        public DateTime DataElaboracao { get; set; }

        [DataMember(), Required()]
        public decimal ValorTotalProdutos { get; set; }

        [DataMember(), Required()]
        public decimal ValorTotalPedido { get; set; }

        [DataMember(), Required()]
        public int StatusPedido { get; set; }

        [DataMember(), Required()]
        public int TipoVenda { get; set; }

        [DataMember(), Required()]
        public decimal TotalParcelas { get; set; }

        [DataMember(), Required()]
        public decimal ValorParcelas { get; set; }

        [DataMember(), Required()]
        public decimal TotalProdutosPedido { get; set; }

        [DataMember(), Required()]
        public DTOCliente Cliente { get; set; }
    }
}