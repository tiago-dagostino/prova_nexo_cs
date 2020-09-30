
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
        IEnumerable<Produto> BuscaPorCliente(int id);

        int TotalProdutoCliente(int d);

    }
}
