using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Integration.Spec;
using SQFramework.Spring.Data.Hibernate;

namespace ControleDeEstoque.Integration.Impl
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository<Fornecedor>
    {
    }
}