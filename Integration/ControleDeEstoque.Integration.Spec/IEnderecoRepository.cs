using SQFramework.Spring;
using SQFramework.Data;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("EnderecoRepository", true)]
    public interface IEnderecoRepository<T> : IRepositoryBase<T>
    {
    }
}