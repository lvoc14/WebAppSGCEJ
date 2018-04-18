using Microsoft.EntityFrameworkCore;
using SGCEJ.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCEJ.Infrastructure.DateTime
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Contato> Contatos { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Cliente
            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                .HasColumnType("Varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
               .HasColumnType("Varchar(200)")
               .IsRequired();

            

            modelBuilder.Entity<Cliente>().Property(e => e.RG)
               .HasColumnType("Varchar(15)")
               .IsRequired();

            #endregion

            #region Contato
            modelBuilder.Entity<Contato>().Property(e => e.Celular)
               .HasColumnType("Varchar(10)")
               .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
               .HasColumnType("Varchar(100)")
               .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.TelefoneFixo)
               .HasColumnType("Varchar(15)")
               .IsRequired();
            #endregion

            #region Endereco

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
              .HasColumnType("Varchar(100)")
              .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Estado)
                .HasColumnType("Varchar(2)")
                .IsRequired();

            #endregion


        }
    }
}
