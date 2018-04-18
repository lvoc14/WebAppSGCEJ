using SGCEJ.ApplicationCore.Entity;
using SGCEJ.Infrastructure.DateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCEJ.Infrastructure.Data
{
   public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Leonardo Victor",
                    CPF = "02276943173",
                    RG ="25359452",
                    DataNascimento="14/08/1996",
                    
                },

                new Cliente
                {
                    Nome = "Janeiro de Jesus",
                    CPF = "18453328145",
                    RG ="269765049",
                    DataNascimento="21/01/1980",

                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
           {
                new Contato
                {
                    Celular = "65981515803",
                    Email = "leonardovictor514@gmail.com",
                    TelefoneFixo ="36412240",
                    Cliente = clientes[0]
                   

                },

                new Contato
                {

                    Celular = "992326349",
                    Email = "janeirodejesus@gmail.com",
                    TelefoneFixo ="36659875",
                    Cliente = clientes[1]

                }
           };

            context.AddRange(contatos);

            var enderecos = new Endereco[]
          {
                new Endereco
                {
                    Bairro = "Morada do Ouro II",
                    Estado = "MT",
                    CEP="78053744",
                    Complemento = "qd31",
                    NumeroCasa ="04"

                },

                new Endereco
                {

                    Bairro = "CPA 2",
                    Estado = "MT",
                    CEP="78056544",
                    Complemento = "98",
                    NumeroCasa ="08"
                },

            
        };

            context.AddRange(enderecos);
        }
    }
}
