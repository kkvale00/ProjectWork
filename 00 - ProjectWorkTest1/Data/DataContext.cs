﻿using _00___ProjectWorkTest1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00___ProjectWorkTest1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dtc) : base(dtc)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quantita>().HasKey(table => new
            {
                table.ProdottoId,
                table.TagliaId,
                table.ColoreId
            });
        }

        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Quantita> Quantitas { get; set; }
        public DbSet<Colore> Colori { get; set; }
        public DbSet<Taglia> Taglie { get; set; }







    }
}
