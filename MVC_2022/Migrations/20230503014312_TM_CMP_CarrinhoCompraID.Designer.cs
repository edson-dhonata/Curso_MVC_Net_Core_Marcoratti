﻿// <auto-generated />
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
    [Migration("20230503014312_TM_CMP_CarrinhoCompraID")]
    partial class TM_CMP_CarrinhoCompraID
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

            modelBuilder.Entity("MVC_2022.Models.Categoria", b =>
                {
                    b.Navigation("Lanches");
                });
#pragma warning restore 612, 618
        }
    }
}
