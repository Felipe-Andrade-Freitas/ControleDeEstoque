using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOProduto
    {
        [DataMember(), Key(), Required()]
        public int Id { get; set; }

        [DataMember(), Required(), StringLength(10)]
        public string CodigoProduto { get; set; }

        [DataMember(), Required(), StringLength(50)]
        public string Nome { get; set; }

        [DataMember(), Required()]
        public DateTime DataFabricacao { get; set; }

        [DataMember(), Required()]
        public DateTime DataVencimento { get; set; }

        [DataMember(), Required()]
        public decimal PrecoProduto { get; set; }

        [DataMember(), Required()]
        public int ProdutoEmEstoque { get; set; }

        [DataMember(), Required(), StringLength(50)]
        public string CodigoBarra { get; set; }

        [DataMember(), Required()]
        public DTOCategoria Categoria { get; set; }

        [DataMember(), Required()]
        public DTOFornecedor Fornecedor { get; set; }
    }
}