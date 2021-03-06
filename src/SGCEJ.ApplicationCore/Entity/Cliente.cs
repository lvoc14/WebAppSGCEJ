﻿using System;
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

        public string DataNascimento { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }
       
        public ICollection<Contato> Contato { get; set; }

        public Endereco Endereco { get; set; }

        public ICollection <ProfissaoCliente>ProfissoesCliente { get; set; }



    }
}
