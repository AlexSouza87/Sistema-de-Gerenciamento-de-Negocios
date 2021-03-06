﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaGerenciadorDeNegocios.Models;

namespace SistemaGerenciadorDeNegocios.Migrations.Aplication
{
    [DbContext(typeof(AplicationContext))]
    partial class AplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.ClienteEndereco", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId", "EnderecoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("ClienteEnderecos");
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroDaCasa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PontoDeReferencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endrecos");
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.Cidade", b =>
                {
                    b.HasOne("SistemaGerenciadorDeNegocios.Models.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId");
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.ClienteEndereco", b =>
                {
                    b.HasOne("SistemaGerenciadorDeNegocios.Models.Cliente", "Cliente")
                        .WithMany("ClienteEnderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaGerenciadorDeNegocios.Models.Endereco", "Endereco")
                        .WithMany("ClienteEnderecos")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaGerenciadorDeNegocios.Models.Endereco", b =>
                {
                    b.HasOne("SistemaGerenciadorDeNegocios.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");
                });
#pragma warning restore 612, 618
        }
    }
}
