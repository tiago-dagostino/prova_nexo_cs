
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

        public Cliente GetById(int id)
        {
            ProdutoRepository _produtoRepository = new ProdutoRepository();
            var result = Db.Set<Cliente>().Find(id);
            result.Produtos = _produtoRepository.BuscaPorCliente(id);
            return result;

        }

        public IEnumerable<Cliente> GetAll()
        {
            ProdutoRepository _produtoRepository = new ProdutoRepository();
            var result = Db.Set<Cliente>().ToList();
            foreach (var cliente in result)
            {
                cliente.TotalProdutos = _produtoRepository.TotalProdutoCliente(cliente.ClienteId);

            }
            return result;
        }
    }
}
