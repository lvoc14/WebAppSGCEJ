using SGCEJ.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SGCEJ.Infrastructure.DateTime
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
                    CPF ="02276943173",
                    RG ="25359452",
                    DataNascimento = ("2010-0-01"),



                }

            };
            context.AddRange(clientes);
            {

            }

        }

       
    }
}
