using System;
using System.Collections.Generic;
using System.Text;


namespace SGCEJ.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {
                
        }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }
       
        public Contato Contatos { get; set; }

        public Endereco Enderecos { get; set; }










    }
}
