﻿// <auto-generated />
using Atv3._1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atv3._1.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20231027231703_Respondido")]
    partial class Respondido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Atv3._1.Models.Contato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Respondido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mensagem")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("servico")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Contatos");
                });
#pragma warning restore 612, 618
        }
    }
}
