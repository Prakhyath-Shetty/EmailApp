﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EMailApp.Repository.Entity
{
    public partial class EmailAppDbContext : DbContext
    {
        public EmailAppDbContext()
        {
        }

        public EmailAppDbContext(DbContextOptions<EmailAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=EMailApp.Database;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.MailReceivers)
                    .HasForeignKey(d => d.ReceiverId)
                    .HasConstraintName("FK_Mail_User1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MailSenders)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK_Mail_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
