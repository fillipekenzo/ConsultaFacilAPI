﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CFApi.Migrations
{
    [DbContext(typeof(CFContext))]
    [Migration("20190711211417_tet")]
    partial class tet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CFApi.Model.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int>("MedicoId");

                    b.Property<int>("PostoId");

                    b.Property<int>("TipoConsultaId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PostoId");

                    b.HasIndex("TipoConsultaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("CFApi.Model.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<int>("TipoConsultaId");

                    b.HasKey("Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("CFApi.Model.MedicoPosto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MedicoId");

                    b.Property<int?>("PostoId");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PostoId");

                    b.ToTable("MedicoPosto");
                });

            modelBuilder.Entity("CFApi.Model.Posto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Lagitude");

                    b.Property<long>("Latitude");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Posto");
                });

            modelBuilder.Entity("CFApi.Model.TipoConsulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TipoConsulta");
                });

            modelBuilder.Entity("CFApi.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("NumeroSus");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CFApi.Model.Consulta", b =>
                {
                    b.HasOne("CFApi.Model.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CFApi.Model.Posto", "Posto")
                        .WithMany("Consulta")
                        .HasForeignKey("PostoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CFApi.Model.TipoConsulta", "TipoConsulta")
                        .WithMany()
                        .HasForeignKey("TipoConsultaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CFApi.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CFApi.Model.MedicoPosto", b =>
                {
                    b.HasOne("CFApi.Model.Medico", "Medico")
                        .WithMany("Posto")
                        .HasForeignKey("MedicoId");

                    b.HasOne("CFApi.Model.Posto", "Posto")
                        .WithMany("Medicos")
                        .HasForeignKey("PostoId");
                });
#pragma warning restore 612, 618
        }
    }
}
