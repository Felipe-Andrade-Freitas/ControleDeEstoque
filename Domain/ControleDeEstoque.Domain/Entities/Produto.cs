using System;
using System.Collections.Generic;
using SQFramework.Spring.Domain;
using ControleDeEstoque.Integration.Spec;

namespace ControleDeEstoque.Domain.Entities
{
    public partial class Produto : DomainBase<Produto, IProdutoRepository<Produto>>
    {
        protected Produto()
        {
        }

        public Produto(Categoria categoria, Fornecedor fornecedor)
        {
            this.SetCategoria(categoria);
            this.SetFornecedor(fornecedor);
        }

        protected int id;
        protected string codigoProduto;
        protected string nome;
        protected DateTime dataFabricacao;
        protected DateTime dataVencimento;
        protected decimal precoProduto;
        protected int produtoEmEstoque;
        protected string codigoBarra;

        protected Categoria categoria;
        protected Fornecedor fornecedor;

        protected IList<ItensPedido> itensPedidos;

        public virtual int Id { get { return id; } }
        public virtual string CodigoProduto { get { return codigoProduto; } set { codigoProduto = value; } }
        public virtual string Nome { get { return nome; } set { nome = value; } }
        public virtual DateTime DataFabricacao { get { return dataFabricacao; } set { dataFabricacao = value; } }
        public virtual DateTime DataVencimento { get { return dataVencimento; } set { dataVencimento = value; } }
        public virtual decimal PrecoProduto { get { return precoProduto; } set { precoProduto = value; } }
        public virtual int ProdutoEmEstoque { get { return produtoEmEstoque; } set { produtoEmEstoque = value; } }
        public virtual string CodigoBarra { get { return codigoBarra; } set { codigoBarra = value; } }

        public virtual Categoria Categoria { get { return categoria; } }
        public virtual Fornecedor Fornecedor { get { return fornecedor; } }

        public virtual IList<ItensPedido> ItensPedidos { get { return (itensPedidos ?? (itensPedidos = new List<ItensPedido>())); } }

        public virtual void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }

        public virtual void SetFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor = fornecedor;
        }
    }
}