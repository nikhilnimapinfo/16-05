using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<office> offices { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<office>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<office>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<office>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.addr)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
