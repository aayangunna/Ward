
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace RoyalKiddiesWard.Data.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {


        }

        //Dbset
        public DbSet<Airtime> Airtimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Transaction Table

            modelBuilder.Entity<Airtime>().HasData(
                       new
                       {
                           Id = 1,
                           AccountBalance = 10000,
                           Amount = 100,
                           AvailableBalance = 1000,
                           Network = 0,
                           PhoneNumber = "09045678973",
                           TransactionDate = new DateTime(2022, 09, 25, 0, 0, 0, 0, DateTimeKind.Local),
                           TransactionStatus = 1
                         });
            modelBuilder.Entity<Airtime>().HasData(
                       new
                       {
                           Id = 1,
                           AccountBalance = 20000,
                           Amount = 200,
                           AvailableBalance = 2000,
                           Network = 1,
                           PhoneNumber = "09045678979",
                           TransactionDate = new DateTime(2022, 09, 24, 0, 0, 0, 0, DateTimeKind.Local),
                           TransactionStatus = 1
                       });



        }
    }
}
