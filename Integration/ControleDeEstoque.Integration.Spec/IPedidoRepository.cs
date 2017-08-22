using SQFramework.Spring;
using SQFramework.Data;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("PedidoRepository", true)]
    public interface IPedidoRepository<T> : IRepositoryBase<T>
    {
    }
}