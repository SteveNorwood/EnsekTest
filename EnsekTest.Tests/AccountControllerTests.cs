using EnsekTest.Api.Controllers;
using EnsekTest.Db;
using EnsekTest.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace EnsekTest.Tests
{
    public class AccountControllerTests
    {
        private EnsekTestContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<EnsekTestContext>().UseInMemoryDatabase("EnsekTest").Options;
            _context = new EnsekTestContext(options);
        }

        [Test]
        public async Task GetAllAccounts_CorrectAmount()
        {
            _context.Accounts.Add(new Account
            {
                FirstName = "A",
                LastName = "Test"
            });
            _context.Accounts.Add(new Account
            {
                FirstName = "B",
                LastName = "Test"
            });
            _context.Accounts.Add(new Account
            {
                FirstName = "C",
                LastName = "Test"
            });

            _context.SaveChanges();

            AccountsController accountsController = new AccountsController(_context);
            var accounts = await accountsController.GetAccounts();

            Assert.AreEqual(3, accounts.Value.Count());
        }

        [Test]
        public async Task GetAllAccounts_EmptyList()
        {
            AccountsController accountsController = new AccountsController(_context);
            var accounts = await accountsController.GetAccounts();

            Assert.AreEqual(0, accounts.Value.Count());
        }

        [Test]
        public async Task GetAccount_Valid()
        {
            _context.Accounts.Add(new Account
            {
                FirstName = "A",
                LastName = "Test"
            });

            _context.SaveChanges();

            AccountsController accountsController = new AccountsController(_context);
            var account = await accountsController.GetAccount(1);
            
            Assert.IsNotNull(account.Value);
        }

        [Test]
        public async Task GetAccount_Invalid()
        {
            AccountsController accountsController = new AccountsController(_context);
            var account = await accountsController.GetAccount(1);

            Assert.IsNull(account.Value);
        }

        [TearDown]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
        }
    }
}