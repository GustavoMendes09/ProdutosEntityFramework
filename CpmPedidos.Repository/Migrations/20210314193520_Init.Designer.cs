﻿// <auto-generated />
using System;
using CpmPedidos.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CpmPedidos.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210314193520_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CpmPedidos.Domain.CategoriaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_categoria_produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("tb_cidade");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<int>("IdEndereço")
                        .HasColumnType("int")
                        .HasColumnName("id_endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("IdEndereço")
                        .IsUnique();

                    b.ToTable("tb_cliente");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<int>("IdImagem")
                        .HasColumnType("int");

                    b.Property<int?>("ImagemId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasPrecision(17, 2)
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("ImagemId");

                    b.ToTable("tb_combo");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("cep");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("id_cidade");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Numero")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("numero");

                    b.Property<byte>("Tipo")
                        .HasColumnType("tinyint")
                        .HasColumnName("tipo");

                    b.HasKey("Id");

                    b.HasIndex("IdCidade");

                    b.ToTable("tb_endereco");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("nome_arquivo");

                    b.Property<bool>("Principal")
                        .HasColumnType("bit")
                        .HasColumnName("principal");

                    b.HasKey("Id");

                    b.ToTable("tb_imagem");
                });

            modelBuilder.Entity("CpmPedidos.Domain.ImagemProduto", b =>
                {
                    b.Property<int>("IdImagem")
                        .HasColumnType("int")
                        .HasColumnName("id_combo");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("id_produto");

                    b.HasKey("IdImagem", "IdProduto");

                    b.HasIndex("IdProduto");

                    b.ToTable("tb_imagem_produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<TimeSpan>("Entrega")
                        .HasColumnType("time")
                        .HasColumnName("entrega");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("cliente");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("numero");

                    b.Property<decimal>("ValorTotal")
                        .HasPrecision(17, 2)
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("valor_total");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("tb_pedido");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("descricao");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasPrecision(17, 2)
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("tb_produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.ProdutoCombo", b =>
                {
                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("id_produto");

                    b.Property<int>("IdCombo")
                        .HasColumnType("int")
                        .HasColumnName("id_combo");

                    b.HasKey("IdProduto", "IdCombo");

                    b.HasIndex("IdCombo");

                    b.ToTable("tb_produto_combo");
                });

            modelBuilder.Entity("CpmPedidos.Domain.ProdutoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int")
                        .HasColumnName("id_pedido");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("id_produto");

                    b.Property<decimal>("Preco")
                        .HasPrecision(17, 2)
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("preco");

                    b.Property<int>("Quantidade")
                        .HasPrecision(2)
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.HasKey("Id");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("tb_produto_pedido");
                });

            modelBuilder.Entity("CpmPedidos.Domain.PromocaoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<int>("IdImagem")
                        .HasColumnType("int")
                        .HasColumnName("id_imagem");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("produto");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasPrecision(17, 2)
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("IdImagem");

                    b.HasIndex("IdProduto");

                    b.ToTable("tb_promocao_produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Cliente", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Endereco", "Endereco")
                        .WithOne("Cliente")
                        .HasForeignKey("CpmPedidos.Domain.Cliente", "IdEndereço")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Combo", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Imagem", "Imagem")
                        .WithMany()
                        .HasForeignKey("ImagemId");

                    b.Navigation("Imagem");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Endereco", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("IdCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("CpmPedidos.Domain.ImagemProduto", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Imagem", "Imagem")
                        .WithMany()
                        .HasForeignKey("IdImagem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CpmPedidos.Domain.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imagem");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Pedido", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Produto", b =>
                {
                    b.HasOne("CpmPedidos.Domain.CategoriaProduto", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("CpmPedidos.Domain.ProdutoCombo", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Combo", "Combo")
                        .WithMany()
                        .HasForeignKey("IdCombo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CpmPedidos.Domain.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combo");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.ProdutoPedido", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Pedido", "Pedido")
                        .WithMany("Produtos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CpmPedidos.Domain.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.PromocaoProduto", b =>
                {
                    b.HasOne("CpmPedidos.Domain.Imagem", "Imagem")
                        .WithMany()
                        .HasForeignKey("IdImagem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CpmPedidos.Domain.Produto", "Produto")
                        .WithMany("Promocoes")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imagem");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CpmPedidos.Domain.CategoriaProduto", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Endereco", b =>
                {
                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Pedido", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CpmPedidos.Domain.Produto", b =>
                {
                    b.Navigation("Promocoes");
                });
#pragma warning restore 612, 618
        }
    }
}