﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ASKGames.Data;

namespace ASKGameShopAPI.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASKGameShopAPI.Models.Admin.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CartaoId");

                    b.Property<string>("Codigo");

                    b.Property<int>("TipoPagamento");

                    b.HasKey("Id");

                    b.HasIndex("CartaoId");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Admin.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Classificacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataLancamento");

                    b.Property<string>("Descricao");

                    b.Property<string>("Desenvolvedora");

                    b.Property<string>("Nome");

                    b.Property<int>("Status");

                    b.Property<string>("Tamanho");

                    b.Property<string>("URLFoto");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Admin.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("DataCompra");

                    b.Property<int?>("FormaPagamentoId");

                    b.Property<int>("Status");

                    b.Property<double>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormaPagamentoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Client.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bandeira");

                    b.Property<string>("CPF");

                    b.Property<string>("CVV");

                    b.Property<int?>("ClienteId");

                    b.Property<string>("NumeroCartao");

                    b.Property<int>("Parcelas");

                    b.Property<int>("Status");

                    b.Property<string>("TitularCartao");

                    b.Property<string>("Validade");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Client.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apelido");

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Status");

                    b.Property<string>("Telefone");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Client.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.NN.ClienteJogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("JogoId");

                    b.Property<int>("PedidoId");

                    b.HasKey("Id");

                    b.ToTable("ClienteJogo");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.NN.JogoNaSacola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("JogoId");

                    b.HasKey("Id");

                    b.ToTable("JogoNaSacola");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Admin.FormaPagamento", b =>
                {
                    b.HasOne("ASKGameShopAPI.Models.Client.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("CartaoId");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Admin.Pedido", b =>
                {
                    b.HasOne("ASKGameShopAPI.Models.Client.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ASKGameShopAPI.Models.Admin.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Client.Cartao", b =>
                {
                    b.HasOne("ASKGameShopAPI.Models.Client.Cliente", "Cliente")
                        .WithMany("Cartoes")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("ASKGameShopAPI.Models.Client.Cliente", b =>
                {
                    b.HasOne("ASKGameShopAPI.Models.Client.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}