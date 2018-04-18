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
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");




            #region Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contato)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

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

            modelBuilder.Entity<Contato>()
               .HasOne(c => c.Cliente)
               .WithMany(c => c.Contato)
               .HasForeignKey(c => c.ClienteId)
               .HasPrincipalKey(c => c.ClienteId);

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

            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.NumeroCasa)
                .HasColumnType("varchar(5)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Complemento)
                .HasColumnType("varchar(100)")
                .IsRequired();



            #endregion

            #region Profissao

            modelBuilder.Entity<Profissao>().Property(e => e.Nome)
              .HasColumnType("Varchar(400)")
              .IsRequired();

            modelBuilder.Entity<Profissao>().Property(e => e.Descricao)
              .HasColumnType("Varchar(1000)")
              .IsRequired();

            modelBuilder.Entity<Profissao>().Property(e => e.CBO)
              .HasColumnType("Varchar(10)")
              .IsRequired();


            #endregion

            #region Profissao Cliente 

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(pc => pc.Cliente)
                .WithMany(c => c.ProfissoesCliente)
                .HasForeignKey(c => c.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
               .HasOne(pc => pc.Profissao)
               .WithMany(c => c.ProfissoesCliente)
               .HasForeignKey(c => c.ProfissaoId);



            #endregion

        }
    }
}
