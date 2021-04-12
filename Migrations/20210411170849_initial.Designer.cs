﻿// <auto-generated />
using API_CETtst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_CETtst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210411170849_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("API_CETtst.Data.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("estoque")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<decimal>("preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            estoque = 10,
                            nome = "Caderno",
                            preco = 7.95m
                        },
                        new
                        {
                            id = 2,
                            estoque = 30,
                            nome = "Borracha",
                            preco = 2.45m
                        },
                        new
                        {
                            id = 3,
                            estoque = 15,
                            nome = "Estojo",
                            preco = 6.25m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
