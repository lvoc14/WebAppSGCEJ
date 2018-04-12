using System;
using System.Collections.Generic;
using System.Text;

namespace SGCEJ.ApplicationCore.Entity
{
    public class Endereco
    {
        public string EnderecoId { get; set; }

        public string Bairro { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

       

    
    }
}
