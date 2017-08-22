using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace ControleDeEstoque.Integration.Spec
{
    [ObjectMap("CategoriaRepository", true)]
    public interface ICategoriaRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarCategorias(int startIndex, int pageSize, string orderProperty, bool orderAscending);
    }
}