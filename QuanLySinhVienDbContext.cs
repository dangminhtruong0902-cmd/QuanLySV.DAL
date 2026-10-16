using Microsoft.EntityFrameworkCore;
using QuanLySV.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySV.DAL
{
    public class QuanLySinhVienDbContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Khoa> Khoas { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=LAPTOP-LSHNM9V4;Database=QuanLySV;Trusted_Connection=True;TrustServerCertificate=True;");
            }//.\SQLEXPRESS,LAPTOP-LSHNM9V4
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SinhVien>().ToTable("SinhVien");
            modelBuilder.Entity<Khoa>().ToTable("Khoa");

            modelBuilder.Entity<SinhVien>()
                .HasOne(sv => sv.Khoa)
                .WithMany(k => k.SinhViens)
                .HasForeignKey(sv => sv.KhoaId);
        }
    }
}

