namespace yanjiuyuanWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DDContext : DbContext
    {
        public DDContext()
            : base("name=DDContext")
        {
        }

        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<LeaveWord> LeaveWord { get; set; }
        public virtual DbSet<NewsAndCases> NewsAndCases { get; set; }

        public virtual DbSet<PicInfo> PicInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jobs>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.JobName)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Require)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.WorkPlace)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.CreateTime)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Pay)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.BigType)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.CreateTime)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Contents)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.CreateTime)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.BigType)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Abstract)
                .IsUnicode(false);
        }
    }
}
