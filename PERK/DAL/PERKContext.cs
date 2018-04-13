using PERK.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PERK.DAL
{
    public class PERKContext : DbContext
    {
        public PERKContext() : base("PERKContext")
        {
        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<EvidenceItem> EvidenceItems { get; set; }
        public DbSet<EvidenceReview> EvidenceReviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}