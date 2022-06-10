using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class HSEContext : DbContext
    {
   

        public HSEContext(DbContextOptions<HSEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HseECheckList> HseECheckLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Persian_100_CI_AI");

            modelBuilder.Entity<HseECheckList>(entity =>
            {
                entity.HasKey(e => e.ECheckListId);

                entity.ToTable("HSE_E_CHECK_LISTS", "HSE");

                entity.Property(e => e.ECheckListId).HasColumnName("E_CHECK_LIST_ID");

                entity.Property(e => e.AddDate)
                    .HasPrecision(6)
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.CodChkHecli).HasColumnName("COD_CHK_HECLI");

                entity.Property(e => e.CreateDate)
                    .HasPrecision(6)
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateInfo)
                    .HasMaxLength(200)
                    .HasColumnName("CREATE_INFO");

                entity.Property(e => e.DesChkHecli)
                    .HasMaxLength(100)
                    .HasColumnName("DES_CHK_HECLI");

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.FlgChkHecli).HasColumnName("FLG_CHK_HECLI");

                entity.Property(e => e.HecltETypId).HasColumnName("HECLT_E_TYP_ID");

                entity.Property(e => e.NamChkHecli)
                    .HasMaxLength(100)
                    .HasColumnName("NAM_CHK_HECLI");

                entity.Property(e => e.NamDepartmentHecli)
                    .HasMaxLength(200)
                    .HasColumnName("NAM_DEPARTMENT_HECLI");

                entity.Property(e => e.RowVersion).HasColumnName("ROW_VERSION");

                entity.Property(e => e.TypChkHecli)
                    .HasMaxLength(200)
                    .HasColumnName("TYP_CHK_HECLI");

                entity.Property(e => e.UnitCehckListsHecli)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("UNIT_CEHCK_LISTS_HECLI");

                entity.Property(e => e.UpdateDate)
                    .HasPrecision(6)
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateInfo)
                    .HasMaxLength(200)
                    .HasColumnName("UPDATE_INFO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
