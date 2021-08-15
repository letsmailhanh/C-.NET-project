using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteFAP.Models
{
    public partial class PRN_FAPProjectContext : DbContext
    {
        public PRN_FAPProjectContext()
        {
        }

        public PRN_FAPProjectContext(DbContextOptions<PRN_FAPProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Campus> Campus { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server =DESKTOP-050TF9U\\SQLEXPRESS; database = PRN_FAPProject;uid=sa;pwd=sa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__Applicat__516F0395564446AD");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__Applicat__C93A4F799A598E48");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ChangeStatusTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileUploaded).HasMaxLength(255);

                entity.Property(e => e.ProcessNote).HasMaxLength(255);

                entity.Property(e => e.Purpose).HasMaxLength(255);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(25);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__Applicati__Statu__1B0907CE");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Applicati__Stude__1920BF5C");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Applicati__TypeI__1A14E395");
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.Property(e => e.CampusId)
                    .HasColumnName("CampusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampusName).HasMaxLength(255);
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.HasKey(e => e.SemId)
                    .HasName("PK__Semester__16D6C7AA869E53F1");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName).HasMaxLength(255);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__Students__32C52A799B66018A");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(25);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CampusId)
                    .HasConstraintName("FK__Students__Campus__1273C1CD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
