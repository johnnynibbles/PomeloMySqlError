using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contexts
{
    public class OneContext : DbContext
    {
        public OneContext(DbContextOptions<OneContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardPosition>(entity =>
            {
                entity.ToTable("board_positions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("the_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Order)
                    .HasColumnName("orderId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime(6)")
                    .HasDefaultValue(null);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasColumnType("int(10) unsigned");
            });
        }
    }
}
