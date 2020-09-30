

using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);

        IEnumerable<Produto> BuscaPorCliente(int id);
        int TotalProdutoCliente(int id);
    }
}
