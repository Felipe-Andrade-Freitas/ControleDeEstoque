using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOCategoria
    {
        [DataMember(), Key(), Required()]
        public int Id { get; set; }

        [DataMember(), Required(), StringLength(10)]
        public string Codigo { get; set; }

        [DataMember(), Required(), StringLength(50)]
        public string Nome { get; set; }
    }
}