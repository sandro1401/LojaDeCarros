﻿// <auto-generated />
using System;
using LojaDeCarros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaDeCarros.Migrations
{
    [DbContext(typeof(LojaDeCarrosContext))]
    [Migration("20240624235543_V1")]
    partial class V1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LojaDeCarros.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<int>("Chassi")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarroId")
                        .HasColumnType("int");

                    b.Property<int>("CompradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Garantia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<double>("ValorVenda")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("CompradorId");

                    b.HasIndex("SellerId");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAdmissão")
                        .HasColumnType("datetime2");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Nota", b =>
                {
                    b.HasOne("LojaDeCarros.Models.Carro", "Carro")
                        .WithMany("Notas")
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LojaDeCarros.Models.Cliente", "Comprador")
                        .WithMany("Notas")
                        .HasForeignKey("CompradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LojaDeCarros.Models.Seller", "Seller")
                        .WithMany("Notas")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Comprador");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Carro", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Cliente", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("LojaDeCarros.Models.Seller", b =>
                {
                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
