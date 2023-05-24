using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFly.Models
{

    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Transaction>()
               .HasOne(t => t.Currency)
               .WithMany()
               .HasForeignKey(t => t.CurrencyId)
               .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Transaction>()
                .HasOne(t => t.Budget)
                .WithMany()
                .HasForeignKey(t => t.BudgetId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Tag>? Tags { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Attachment>? Attachments { get; set; }
        public DbSet<Bill>? Bills { get; set; }
        public DbSet<Currency>? Currencies { get; set; }
        public DbSet<Group>? Groups { get; set; }
        public DbSet<GroupType>? GroupTypes { get; set; }
        public DbSet<RepeatFrequency>? RepeatFrequencies { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<AccountType>? AccountTypes { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<PiggyBank>? PiggyBanks { get; set; }
        public DbSet<Budget>? Budgets { get; set; }
        public DbSet<AutoBudget>? AutoBudgets { get; set; }
        public DbSet<AutoBudgetDetail>? AutoBudgetDetails { get; set; }
        public DbSet<Liability>? Liabilities { get; set; }
        public DbSet<LiabilityInOut>? LiabilityInOuts { get; set; }
        public DbSet<Transaction>? Transactions { get; set; }
        public DbSet<TransactionType>? TransactionTypes { get; set; }

    }
}
