using NHibernate.Criterion;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Integration.Spec;
using SQFramework.Data.Pagging;
using SQFramework.Spring.Data.Hibernate;

namespace ControleDeEstoque.Integration.Impl
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository<Cliente>
    {
        public PageMessage<Cliente> ListarClientes(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            var criteria = DetachedCriteria.For<Cliente>();

            return Page<Cliente>(criteria, startIndex, pageSize, orderProperty, orderAscending);
        }
    }
}