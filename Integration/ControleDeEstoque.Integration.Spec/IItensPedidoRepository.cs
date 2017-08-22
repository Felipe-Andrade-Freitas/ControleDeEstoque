using SQFramework.Spring;
using SQFramework.Data;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("ItensPedidoRepository", true)]
    public interface IItensPedidoRepository<T> : IRepositoryBase<T>
    {
    }
}