using System;
using System.Collections.Generic;
using System.ServiceModel;
using SQFramework.Core;
using SQFramework.Data.Pagging;
using Spring.Transaction.Interceptor;
using Spring.Transaction;
using ControleDeEstoque.Services.Spec.DataTransferObjects;
using ControleDeEstoque.Services.Spec.Services;
using ControleDeEstoque.Domain.Entities;

namespace ControleDeEstoque.Services.Impl.Services
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerSession)]
    public class CadastroService : ServiceBase, ICadastroService
    {
        [Transaction(TransactionPropagation.Required)]
        public DTOCliente SalvarCliente(DTOCliente dto)
        {
            Cliente cliente = null;

            var endereco = Endereco.GetRepository().Get(dto.Endereco.Id);

            if (dto.Id > 0)
            {
                cliente = Cliente.GetRepository().Get(dto.Id);

                if (cliente == null)
                    throw new Exception("Cliente não encontrado(a)!");

                dto.Transform<Cliente>(cliente);

                cliente.SetEndereco(endereco);
            }
            else
            {
                cliente = new Cliente(endereco);
                dto.Transform<Cliente>(cliente);
            }

            cliente.Save();

            return cliente.Transform<DTOCliente>();
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = true)]
        public DTOCliente ObterCliente(int id)
        {
            return Cliente.GetRepository().Get(id).Transform<DTOCliente>();
        }

        [Transaction(TransactionPropagation.Required)]
        public void DeletarCliente(int id)
        {
            var item = Cliente.GetRepository().Get(id);
            item.Delete();
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = true)]
        public IList<DTOCliente> ListarClientes()
        {
            return Cliente.GetRepository().ListAll().TransformList<DTOCliente>();
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = true)]
        public PageMessage<DTOCliente> ListarClientes(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            return Cliente.GetRepository().ListarClientes(startIndex, pageSize, orderProperty, orderAscending)
                .Transform<PageMessage<DTOCliente>>();
        }

        [Transaction(TransactionPropagation.Required)]
        public DTOCategoria SalvarCategoria(DTOCategoria dto)
        {
            Categoria categoria = null;

            if (dto.Id > 0)
            {
                categoria = Categoria.GetRepository().Get(dto.Id);

                if (categoria == null)
                    throw new Exception("Categoria não encontrado(a)!");

                dto.Transform<Categoria>(categoria);
            }
            else
            {
                categoria = dto.Transform<Categoria>();
            }

            categoria.Save();

            return categoria.Transform<DTOCategoria>();
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = true)]
        public DTOCategoria ObterCategoria(int id)
        {
            return Categoria.GetRepository().Get(id).Transform<DTOCategoria>();
        }

        [Transaction(TransactionPropagation.Required)]
        public void DeletarCategoria(int id)
        {
            var item = Categoria.GetRepository().Get(id);
            item.Delete();
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = true)]
        public IList<DTOCategoria> ListarCategorias()
        {
            return Categoria.GetRepository().ListAll().TransformList<DTOCategoria>();
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = true)]
        public PageMessage<DTOCategoria> ListarCategorias(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            return Categoria.GetRepository().ListarCategorias(startIndex, pageSize, orderProperty, orderAscending)
                .Transform<PageMessage<DTOCategoria>>();
        }
    }
}