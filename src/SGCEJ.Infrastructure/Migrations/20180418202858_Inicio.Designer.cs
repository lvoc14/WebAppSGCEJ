﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SGCEJ.Infrastructure.DateTime;
using System;

namespace SGCEJ.Infrastructure.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20180418202858_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("Varchar(11)");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(200)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("TelefoneFixo")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.HasKey("ContatoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<string>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("Varchar(2)");

                    b.Property<string>("NumeroCasa")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.Profissao", b =>
                {
                    b.Property<int>("ProfissaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CBO")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("Varchar(1000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(400)");

                    b.HasKey("ProfissaoId");

                    b.ToTable("Profissao");
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.ProfissaoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProfissaoId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProfissaoId");

                    b.ToTable("ProfissaoCliente");
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.Contato", b =>
                {
                    b.HasOne("SGCEJ.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("Contato")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("SGCEJ.ApplicationCore.Entity.Cliente", "Clientes")
                        .WithOne("Endereco")
                        .HasForeignKey("SGCEJ.ApplicationCore.Entity.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGCEJ.ApplicationCore.Entity.ProfissaoCliente", b =>
                {
                    b.HasOne("SGCEJ.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("ProfissoesCliente")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGCEJ.ApplicationCore.Entity.Profissao", "Profissao")
                        .WithMany("ProfissoesCliente")
                        .HasForeignKey("ProfissaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}