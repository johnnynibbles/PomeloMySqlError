﻿using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contexts
{
    public class TwoContext : DbContext
    {
        public TwoContext(DbContextOptions<TwoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Season>(entity =>
            {
                entity.ToTable("seasons");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("startDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("endDate")
                    .HasColumnType("datetime(6)");

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