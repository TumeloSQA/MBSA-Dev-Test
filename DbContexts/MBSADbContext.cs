using MBSA_Dev_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSA_Dev_Test.DbContexts
{
    public class MBSADbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MBSADbContext()
        {
        }

        public MBSADbContext(DbContextOptions<MBSADbContext> options)
            : base(options)
        {
        }

        public virtual Microsoft.EntityFrameworkCore.DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("database:connection");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasIndex(e => e.ID)
                    .IsUnique();

                entity.Property(e => e.ID)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectName).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Deleted);
            });

        }

    }
}
