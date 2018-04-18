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

        public string CEP { get; set; }

        public string NumeroCasa { get; set; }

        public string Complemento { get; set; }

        public int ClienteId { get; set; }

        public Cliente Clientes { get; set; }

       

    
    }
}
