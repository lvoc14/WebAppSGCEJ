using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCEJ.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCEJ.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

        }
    }
}
