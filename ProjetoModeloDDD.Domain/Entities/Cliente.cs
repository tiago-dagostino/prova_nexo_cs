using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProjetoModeloDDD.Domain.Entities
{
    public enum ETipoCliente
    {
        Simples = 0,
        Prata = 1,
        Ouro = 2,
        Platina = 3,
        Diamante = 4

    }
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        [NotMapped]
        public int TotalProdutos { get; set; }

        [NotMapped]
        public string TipoCliente {
            get
            {
                return ClienteEspecial(this).ToString();
            } 
        }

        public bool isClienteEspecial(Cliente cliente)
        {
            if (!cliente.Ativo)
                return false;

            var tipo = ClienteEspecial(cliente);

            if (tipo == ETipoCliente.Simples)
                return false;
            return true;

        }

        public ETipoCliente ClienteEspecial(Cliente cliente)
        {
            if (!cliente.Ativo)
                return ETipoCliente.Simples;

            ETipoCliente result = ETipoCliente.Simples;
            if (DateTime.Now.Year - cliente.DataCadastro.Year >= 5)
            {
                result = ETipoCliente.Prata;
            }
            if (TotalProdutos >= 2000)
            {
                result = ETipoCliente.Ouro;
            }
            if (TotalProdutos >= 5000)
            {
                result = ETipoCliente.Platina;
            }
            if (TotalProdutos >= 10000)
            {
                result = ETipoCliente.Diamante;
            }
            return result;

        }
    }
}
