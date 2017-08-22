using System.Collections.Generic;
using System.ServiceModel;
using SQFramework.Spring;
using SQFramework.Data.Pagging;
using ControleDeEstoque.Services.Spec.DataTransferObjects;

namespace ControleDeEstoque.Services.Spec.Services
{
    [ServiceContract]
    [ObjectMap("ServiceBase", true)]
    public interface ICadastroService : IServiceBase
    {
        [OperationContract]
        DTOCliente SalvarCliente(DTOCliente dto);

        [OperationContract]
        DTOCliente ObterCliente(int id);

        [OperationContract]
        void DeletarCliente(int id);

        [OperationContract]
        IList<DTOCliente> ListarClientes();

        [OperationContract(Name = "ListarClientesPaged")]
        PageMessage<DTOCliente> ListarClientes(int startIndex, int pageSize, string orderProperty, bool orderAscending);

        [OperationContract]
        DTOCategoria SalvarCategoria(DTOCategoria dto);

        [OperationContract]
        DTOCategoria ObterCategoria(int id);

        [OperationContract]
        void DeletarCategoria(int id);

        [OperationContract]
        IList<DTOCategoria> ListarCategorias();

        [OperationContract(Name = "ListarCategoriasPaged")]
        PageMessage<DTOCategoria> ListarCategorias(int startIndex, int pageSize, string orderProperty, bool orderAscending);
    }
}