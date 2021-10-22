using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SG_Blazor_4.Shared.Models;
using SG_Blazor_4.Shared.Models.Psico;

#nullable disable

namespace SG_Blazor_4.Server.Datos
{
    public partial class SG_Blazor_4Context : DbContext
    {
        public SG_Blazor_4Context()
        {
        }

        public SG_Blazor_4Context(DbContextOptions<SG_Blazor_4Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }



        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Ba7Model> Ba7Models { get; set; }
        public DbSet<LSB_50Model> LSB_50Model { get; set; }
        public DbSet<OrdenAtencion> ordenAtencions { get; set; }
    }

}
