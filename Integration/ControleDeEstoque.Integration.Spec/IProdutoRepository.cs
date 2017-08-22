using SQFramework.Spring;
using SQFramework.Data;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("ProdutoRepository", true)]
    public interface IProdutoRepository<T> : IRepositoryBase<T>
    {
    }
}