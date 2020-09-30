

using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
/*
        IEnumerable<Produto> BuscaPorCliente(int id);

        int TotalProdutoCliente(int id);
*/
    }
}
