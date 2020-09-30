
using System.Collections.Generic;

using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscaPorNome(nome);
        }
/*
        public IEnumerable<Produto> BuscarPorCliente(int id)
        {
            return _produtoService.BuscaPorCliente(id);
        }
        public int TotalProdutoCliente(int id)
        {
            return _produtoService.TotalProdutoCliente(id);
        }
*/
    }
}
