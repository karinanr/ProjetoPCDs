﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoPCD.Models;

namespace ProjetoPCD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211222234401_corrigindo")]
    partial class corrigindo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoPCD.Models.Candidatura", b =>
                {
                    b.Property<int>("id_Candidatura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cursoid_Curso")
                        .HasColumnType("int");

                    b.Property<int?>("Empresaid_Empresa")
                        .HasColumnType("int");

                    b.Property<int?>("Usuarioid_Usuario")
                        .HasColumnType("int");

                    b.Property<int?>("Vagaid_Vaga")
                        .HasColumnType("int");

                    b.HasKey("id_Candidatura");

                    b.HasIndex("Cursoid_Curso");

                    b.HasIndex("Empresaid_Empresa");

                    b.HasIndex("Usuarioid_Usuario");

                    b.HasIndex("Vagaid_Vaga");

                    b.ToTable("Candidatura");
                });

            modelBuilder.Entity("ProjetoPCD.Models.Curso", b =>
                {
                    b.Property<int>("id_Curso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Curso");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProjetoPCD.Models.Empresa", b =>
                {
                    b.Property<int>("id_Empresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Parceira")
                        .HasColumnType("bit");

                    b.Property<string>("RamoDeAtividade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Empresa");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("ProjetoPCD.Models.Usuario", b =>
                {
                    b.Property<int>("id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoPCD.Models.Vaga", b =>
                {
                    b.Property<int>("id_Vaga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Benefícios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CargaHoraria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cargo")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Empresaid_Empresa")
                        .HasColumnType("int");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id_Vaga");

                    b.HasIndex("Empresaid_Empresa");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("ProjetoPCD.Models.Candidatura", b =>
                {
                    b.HasOne("ProjetoPCD.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("Cursoid_Curso");

                    b.HasOne("ProjetoPCD.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("Empresaid_Empresa");

                    b.HasOne("ProjetoPCD.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuarioid_Usuario");

                    b.HasOne("ProjetoPCD.Models.Vaga", "Vaga")
                        .WithMany()
                        .HasForeignKey("Vagaid_Vaga");

                    b.Navigation("Curso");

                    b.Navigation("Empresa");

                    b.Navigation("Usuario");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("ProjetoPCD.Models.Vaga", b =>
                {
                    b.HasOne("ProjetoPCD.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("Empresaid_Empresa");

                    b.Navigation("Empresa");
                });
#pragma warning restore 612, 618
        }
    }
}
