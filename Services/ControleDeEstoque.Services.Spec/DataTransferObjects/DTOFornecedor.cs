using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOFornecedor
    {
        [DataMember(), Key(), Required()]
        public int Id { get; set; }

        [DataMember(), Required(), StringLength(50)]
        public string Nome { get; set; }

        [DataMember(), Required(), StringLength(20)]
        public string Codigo { get; set; }

        [DataMember(), Required()]
        public int Telefone { get; set; }

        [DataMember(), Required(), StringLength(100)]
        public string NomeFantasia { get; set; }

        [DataMember(), Required(), StringLength(11)]
        public string Cnpj { get; set; }

        [DataMember(), Required()]
        public DTOEndereco Endereco { get; set; }
    }
}