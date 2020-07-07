using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SParcialAP1.Entidades;

namespace SParcialAP1.DAL
{
    public class Contexto : DbContext
    {

        public virtual DbSet<Proyecto> Proyectos  { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/DataBase3.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>().HasData(new Tarea { TareaId = 1, TipoTarea = "Analisis" });
            modelBuilder.Entity<Tarea>().HasData(new Tarea { TareaId = 2, TipoTarea = "Diseño" });
            modelBuilder.Entity<Tarea>().HasData(new Tarea { TareaId = 3, TipoTarea = "Programacion" });
            modelBuilder.Entity<Tarea>().HasData(new Tarea { TareaId = 4, TipoTarea = "Prueba" });
        }
    }
}