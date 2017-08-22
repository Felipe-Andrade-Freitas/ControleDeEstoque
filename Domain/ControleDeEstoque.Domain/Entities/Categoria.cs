using System.Collections.Generic;
using SQFramework.Spring.Domain;
using ControleDeEstoque.Integration.Spec;

namespace ControleDeEstoque.Domain.Entities
{
    public partial class Categoria : DomainBase<Categoria, ICategoriaRepository<Categoria>>
    {
        public Categoria()
        {
        }

        protected int id;
        protected string codigo;
        protected string nome;

        protected IList<Produto> produtos;

        public virtual int Id { get { return id; } }
        public virtual string Codigo { get { return codigo; } set { codigo = value; } }
        public virtual string Nome { get { return nome; } set { nome = value; } }

        public virtual IList<Produto> Produtos { get { return (produtos ?? (produtos = new List<Produto>())); } }
    }
}