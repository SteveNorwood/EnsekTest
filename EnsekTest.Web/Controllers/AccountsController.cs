using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EnsekTest.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnsekTest.Web.Controllers
{
    public class AccountsController : Controller
    {
        private IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<IActionResult> Index()
        {
            var accounts = await _accountService.GetAccountsAsync();

            return View(accounts);
        }
        public async Task<IActionResult> Details(int id)
        {
            var account = await _accountService.GetAccountAsync(id);

            return View(account);
        }
    }
}
