using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("ClienteRepository", true)]
    public interface IClienteRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarClientes(int startIndex, int pageSize, string orderProperty, bool orderAscending);
    }
}