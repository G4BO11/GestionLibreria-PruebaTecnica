﻿// <auto-generated />
using System;
using GestionLibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionLibreriaPrueba.Migrations
{
    [DbContext(typeof(GestionLibreriaContext))]
    partial class GestionLibreriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AutorId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Comentario", b =>
                {
                    b.Property<int>("ComentarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComentarioID"));

                    b.Property<string>("ComentarioContenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ComentarioFecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibroID")
                        .HasColumnType("int");

                    b.HasKey("ComentarioID");

                    b.HasIndex("LibroID");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Libro", b =>
                {
                    b.Property<int>("LibroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibroID"));

                    b.Property<int>("AutorID")
                        .HasColumnType("int");

                    b.Property<int>("LibAnno")
                        .HasColumnType("int");

                    b.Property<string>("LibDescripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibEditorial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibGenero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibTitulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibroID");

                    b.HasIndex("AutorID");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Comentario", b =>
                {
                    b.HasOne("GestionLibreriaPrueba.Models.Libro", "Libro")
                        .WithMany("Comentarios")
                        .HasForeignKey("LibroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Libro", b =>
                {
                    b.HasOne("GestionLibreriaPrueba.Models.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Autor", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("GestionLibreriaPrueba.Models.Libro", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}
