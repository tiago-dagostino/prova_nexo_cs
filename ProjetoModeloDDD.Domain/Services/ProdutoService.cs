﻿

using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository) 
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoRepository.BuscaPorNome(nome);
        }

        public IEnumerable<Produto> BuscaPorCliente(int id)
        {
            return _produtoRepository.BuscaPorCliente(id);
        }

        public int TotalProdutoCliente(int id)
        {
            return _produtoRepository.TotalProdutoCliente(id);
        }
    }
}
