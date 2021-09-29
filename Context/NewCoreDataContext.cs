using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using NewCore.Data.Models;

#nullable disable

namespace NewCore.Data.Context
{
    public partial class NewCoreDataContext : DbContext
    {
        public NewCoreDataContext()
        {
        }

        public NewCoreDataContext(DbContextOptions<NewCoreDataContext> options)
            : base(options)
        {
        }

        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
             .AddJsonFile("appsettings.json");

            //var config = builder.Build();
            IConfiguration Configuration = builder.Build();
            //return Configuration["ConnectionStrings:DefaultConnection"];
            return Configuration.GetConnectionString("TestDBConnection");
        }

        public virtual DbSet<Coverage> Coverages { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=TestDB;User=sa;Password=Pass#Word1");
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Coverage>(entity =>
            {
                entity.HasKey(e => e.CvgRef)
                    .HasName("PK__Coverage__D23AF24AA3A486D8");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerRef).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.HasKey(e => e.PolRef)
                    .HasName("PK__Policy__EF4EC41ADABA8C87");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
