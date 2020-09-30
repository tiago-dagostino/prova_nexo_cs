

using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome.Contains(nome));
        }

        public IEnumerable<Produto> BuscaPorCliente(int id)
        {
            return Db.Produtos.Where(p => p.ClienteId == id);
        }

        public int TotalProdutoCliente(int id)
        {
            return Db.Produtos.Where(p => p.ClienteId == id).Count();
        }


    }
}
