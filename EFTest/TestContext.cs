using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    public class TestContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Composition> Compositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>()
                .HasMany(c => c.ParentCompositions)
                .WithRequired(c => c.Child)
                .HasForeignKey(c => c.ChildId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(c => c.ChildCompositions)
                .WithRequired(c => c.Parent)
                .HasForeignKey(c => c.ParentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Composition>()
                .HasRequired(i => i.Parent)
                .WithMany(p => p.ChildCompositions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Composition>()
                .HasRequired(i => i.Child)
                .WithMany(p => p.ParentCompositions)
                .WillCascadeOnDelete(false); 
        }
    }
}
