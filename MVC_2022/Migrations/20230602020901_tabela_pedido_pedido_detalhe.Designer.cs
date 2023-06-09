﻿// <auto-generated />
using System;
using MVC_2022.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_2022.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230602020901_tabela_pedido_pedido_detalhe")]
    partial class tabela_pedido_pedido_detalhe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC_2022.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ITEM_CARRINHO_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarrinhoCompraItemId"), 1L, 1);

                    b.Property<string>("CarrinhoCompraId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("ITEM_CARRINHO_COMPRA_ID");

                    b.Property<int>("LancheId")
                        .HasColumnType("int")
                        .HasColumnName("ITEM_LANCHE_ID");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("ITEM_QUANTIDADE");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("LancheId");

                    b.ToTable("TB_ITENS_CARRINHO");
                });

            modelBuilder.Entity("MVC_2022.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CATEGORIA_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"), 1L, 1);

                    b.Property<string>("CategoriaDescricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("CATEGORIA_DESCRICAO");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CATEGORIA_NOME");

                    b.HasKey("CategoriaId");

                    b.ToTable("TB_CATEGORIAS");
                });

            modelBuilder.Entity("MVC_2022.Models.Lanche", b =>
                {
                    b.Property<int>("LancheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LANCHE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LancheId"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("LANCHE_CATEGORIA_ID");

                    b.Property<string>("LancheDescricaoCurta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("LANCHE_DESCRICAO_CURTA");

                    b.Property<string>("LancheDescricaoDetalhada")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("LANCHE_DESCRICAO_DETALHADA");

                    b.Property<bool>("LancheEmEstoque")
                        .HasColumnType("bit")
                        .HasColumnName("LANCHE_EM_ESTOQUE");

                    b.Property<string>("LancheImagemThumbnailURL")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("LANCHE_IMAGE_THUMB");

                    b.Property<string>("LancheImagemURL")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("LANCHE_IMAGE");

                    b.Property<bool>("LancheIsPreferido")
                        .HasColumnType("bit")
                        .HasColumnName("LANCHE_PREFERIDO");

                    b.Property<string>("LancheNome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("LANCHE_NOME");

                    b.Property<decimal>("LanchePreco")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("LANCHE_VALOR");

                    b.HasKey("LancheId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("TB_LANCHES");
                });

            modelBuilder.Entity("MVC_2022.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PEDIDO_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"), 1L, 1);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("PEDIDO_CEP");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PEDIDO_CIDADE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PEDIDO_EMAIL");

                    b.Property<string>("Endereco1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PEDIDO_ENDERECO");

                    b.Property<string>("Endereco2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PEDIDO_COMPLEMENTO");

                    b.Property<string>("Estado")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("PEDIDO_ESTADO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PEDIDO_NOME");

                    b.Property<DateTime?>("PedidoEntregueEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("PEDIDO_DATA_ENVIO");

                    b.Property<DateTime>("PedidoEnviado")
                        .HasColumnType("datetime2")
                        .HasColumnName("PEDIDO_DATA");

                    b.Property<decimal>("PedidoTotal")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PEDIDO_VALOR_TOTAL");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PEDIDO_SOBRENOME");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("PEDIDO_TELEFONE");

                    b.Property<int>("TotalItensPedido")
                        .HasColumnType("int")
                        .HasColumnName("PEDIDO_QTD_ITENS");

                    b.HasKey("PedidoId");

                    b.ToTable("TB_PEDIDO");
                });

            modelBuilder.Entity("MVC_2022.Models.PedidoDetalhe", b =>
                {
                    b.Property<int>("PedidoDetalheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PEDIDO_DETALHE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoDetalheId"), 1L, 1);

                    b.Property<int>("LancheId")
                        .HasColumnType("int")
                        .HasColumnName("PEDIDO_DETALHE_LANCHE_ID");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int")
                        .HasColumnName("PEDIDO_DETALHE_PEDIDO_ID");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PEDIDO_DETALHE_VALOR");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("PEDIDO_DETALHE_QTD");

                    b.HasKey("PedidoDetalheId");

                    b.HasIndex("LancheId");

                    b.HasIndex("PedidoId");

                    b.ToTable("TB_PEDIDO_DETALHE");
                });

            modelBuilder.Entity("MVC_2022.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("MVC_2022.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");
                });

            modelBuilder.Entity("MVC_2022.Models.Lanche", b =>
                {
                    b.HasOne("MVC_2022.Models.Categoria", "Categoria")
                        .WithMany("Lanches")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("MVC_2022.Models.PedidoDetalhe", b =>
                {
                    b.HasOne("MVC_2022.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_2022.Models.Pedido", "Pedido")
                        .WithMany("PedidoItens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("MVC_2022.Models.Categoria", b =>
                {
                    b.Navigation("Lanches");
                });

            modelBuilder.Entity("MVC_2022.Models.Pedido", b =>
                {
                    b.Navigation("PedidoItens");
                });
#pragma warning restore 612, 618
        }
    }
}
