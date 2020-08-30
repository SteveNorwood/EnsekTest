using CsvHelper;
using EnsekTest.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace EnsekTest.Db
{
    // To create new migrations and update the database, use the following calls in the package manager console, ensuring it runs on EnsekTest.Api
    // EntityFrameworkCore\Add-Migration <Migration Name>
    // EntityFrameworkCore\Update-Database

    public class EnsekTestContext : DbContext
    {
        // Need this ctor for DI
        public EnsekTestContext(DbContextOptions<EnsekTestContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seeding
            if (Database.IsSqlite())
            {
                // Uncomment the below code if you need to debug the database seeding
                //if (!System.Diagnostics.Debugger.IsAttached)
                //    System.Diagnostics.Debugger.Launch();

                // Need to get a reference to the valid accounts for seeding the meter readings
                Account[] accounts = SeedAccountData();
                List<int> validAccounts = accounts.Select(x => x.Id).Distinct().ToList();

                modelBuilder.Entity<Account>().HasData(accounts);
                modelBuilder.Entity<MeterReading>().HasData(SeedMeterReadings(validAccounts));
            }
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #region Seeding
        private Account[] SeedAccountData()
        {
            List<Account> accounts = new List<Account>();

            using (var streamReader = new StreamReader(@"Database\SeedData\Test_Accounts.csv"))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                // Need to do a Read & ReadHeader to skip past the header
                csvReader.Read();
                csvReader.ReadHeader();
                while (csvReader.Read())
                {
                    try
                    {
                        int accountId = csvReader.GetField<int>("AccountId");
                        
                        if (accounts.Where(x => x.Id == accountId).Any())
                            continue;

                        string firstName = csvReader.GetField<string>("FirstName");
                        string lastName = csvReader.GetField<string>("LastName");

                        accounts.Add(new Account()
                        {
                            Id = accountId,
                            FirstName = firstName,
                            LastName = lastName
                        });
                    }
                    catch (Exception)
                    { 
                        continue;
                    }
                }
            }

            return accounts.ToArray();
        }

        private MeterReading[] SeedMeterReadings(List<int> validAccounts)
        {
            List<MeterReading> meterReadings = new List<MeterReading>();

            using (var streamReader = new StreamReader(@"Database\SeedData\Meter_Reading.csv"))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                csvReader.Configuration.TypeConverterOptionsCache.AddOptions<DateTime>(new CsvHelper.TypeConversion.TypeConverterOptions() { Formats = new[] { "dd/MM/yyyy HH:mm" } });

                // Need to do a Read & ReadHeader to skip past the header
                csvReader.Read();
                csvReader.ReadHeader();

                // Need integer for Id column, not poplated by default during seeding
                int i = 1;
                while (csvReader.Read())
                {
                    try
                    {
                        int accountId = csvReader.GetField<int>("AccountId");
                        if (validAccounts.Contains(accountId))
                        {
                            DateTime meterReadingDateTime = csvReader.GetField<DateTime>("MeterReadingDateTime");
                            int meterReadingValue = csvReader.GetField<int>("MeterReadValue");

                            meterReadings.Add(new MeterReading()
                            {
                                Id = i++,
                                AccountId = accountId,
                                MeterReadingDateTime = meterReadingDateTime,
                                MeterReadValue = meterReadingValue.ToString().PadLeft(5, '0')
                            });
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }

            return meterReadings.ToArray();
        }

        #endregion

        public DbSet<Account> Accounts { get; set; }
        public DbSet<MeterReading> MeterReadings { get; set; }
    }
}
