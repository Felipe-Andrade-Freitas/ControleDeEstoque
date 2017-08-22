using SQFramework.Spring;
using SQFramework.Data;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("FornecedorRepository", true)]
    public interface IFornecedorRepository<T> : IRepositoryBase<T>
    {
    }
}