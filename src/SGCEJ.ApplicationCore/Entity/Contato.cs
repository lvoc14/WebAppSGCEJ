using System;
using System.Collections.Generic;
using System.Text;

namespace SGCEJ.ApplicationCore.Entity
{
    public class Contato
    {

        public int ContatoId { get; set; }

        public string Celular { get; set; }

        public string TelefoneFixo { get; set; }

        public string Email { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

    }
}
