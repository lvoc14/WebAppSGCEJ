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
        }
    }
}
