﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SParcialAP1.DAL;

namespace SParcialAP1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200707015056_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("SParcialAP1.Entidades.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("TiempoTotal")
                        .HasColumnType("REAL");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("SParcialAP1.Entidades.ProyectoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Tiempo")
                        .HasColumnType("REAL");

                    b.Property<string>("TipoTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("TareaId");

                    b.ToTable("ProyectoDetalle");
                });

            modelBuilder.Entity("SParcialAP1.Entidades.Tarea", b =>
                {
                    b.Property<int>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<double>("Tiempo")
                        .HasColumnType("REAL");

                    b.Property<string>("TipoTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("TareaId");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            TareaId = 1,
                            Requerimiento = "",
                            Tiempo = 0.0,
                            TipoTarea = "Analisis"
                        },
                        new
                        {
                            TareaId = 2,
                            Requerimiento = "",
                            Tiempo = 0.0,
                            TipoTarea = "Diseño"
                        },
                        new
                        {
                            TareaId = 3,
                            Requerimiento = "",
                            Tiempo = 0.0,
                            TipoTarea = "Programacion"
                        },
                        new
                        {
                            TareaId = 4,
                            Requerimiento = "",
                            Tiempo = 0.0,
                            TipoTarea = "Prueba"
                        });
                });

            modelBuilder.Entity("SParcialAP1.Entidades.ProyectoDetalle", b =>
                {
                    b.HasOne("SParcialAP1.Entidades.Proyecto", "proyecto")
                        .WithMany("ProyectoDetalle")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SParcialAP1.Entidades.Tarea", "tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
