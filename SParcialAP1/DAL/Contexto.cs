using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SParcialAP1.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Sources= DATA\SParcialAP1.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
